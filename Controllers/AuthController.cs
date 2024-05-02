using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using GiftGrabber.Models;
using GiftGrabber.Models.DTOs;
using GiftGrabber.Data;
using Microsoft.EntityFrameworkCore;

namespace GiftGrabber.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private GiftGrabberDbContext _dbContext;
    private UserManager<IdentityUser> _userManager;

    public AuthController(GiftGrabberDbContext context, UserManager<IdentityUser> userManager)
    {
        _dbContext = context;
        _userManager = userManager;
    }

    [HttpPost("login")]
    public IActionResult Login([FromHeader(Name = "Authorization")] string authHeader)
    {
        try
        {
            string encodedCreds = authHeader.Substring(6).Trim();
            string creds = Encoding
            .GetEncoding("iso-8859-1")
            .GetString(Convert.FromBase64String(encodedCreds));

            // Get email and password
            int separator = creds.IndexOf(':');
            string email = creds.Substring(0, separator);
            string password = creds.Substring(separator + 1);

            var user = _dbContext.Users.Where(u => u.Email == email).FirstOrDefault();
            var userRoles = _dbContext.UserRoles.Where(ur => ur.UserId == user.Id).ToList();
            var hasher = new PasswordHasher<IdentityUser>();
            var result = hasher.VerifyHashedPassword(user, user.PasswordHash, password);
            if (user != null && result == PasswordVerificationResult.Success)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)

                };

                foreach (var userRole in userRoles)
                {
                    var role = _dbContext.Roles.FirstOrDefault(r => r.Id == userRole.RoleId);
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                 // Create authentication properties with custom expiration time
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7) // Expires in one week
                };

                HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), authProperties).Wait();

                Response.Headers["Expires"] = DateTime.UtcNow.AddDays(7).ToString("r");

                // Set the cookie with options
                Response.Cookies.Append("GiftGrabberLoginCookie", "cookieValue");

                return Ok();
            }

            return new UnauthorizedResult();
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }
    }

    [HttpGet]
    [Route("logout")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public IActionResult Logout()
    {
        try
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }
    }

    [HttpGet("Me")]
    // [Authorize]
    public IActionResult Me()
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var profile = _dbContext.UserProfiles
            .Include(up => up.WishLists).ThenInclude(wl => wl.ListType)
            .Include(up => up.GiftClaims).ThenInclude(gc => gc.Item).ThenInclude(i => i.WishList)
            .SingleOrDefault(up => up.IdentityUserId == identityUserId);
        var roles = User.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();
        if (profile != null)
        {
            var userDto = new UserProfileDTO
            {
                // Id = profile.Id,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                // IdentityUserId = identityUserId,
                UserName = User.FindFirstValue(ClaimTypes.Name),
                Email = User.FindFirstValue(ClaimTypes.Email),
                Roles = roles,
                WishLists = profile.WishLists.Select(w => new WishListDTO
                {
                    Id = w.Id,
                    Name = w.Name,
                    ListTypeId = w.ListTypeId,
                    ListType = new ListTypeDTO
                    {
                        Id = w.ListType.Id,
                        Name = w.ListType.Name
                    },
                    UserId = w.UserId,
                    ForSelf = w.ForSelf
                }).ToList(),
                GiftClaims = profile.GiftClaims.Select(gc => new GiftClaimDTO {
                    Id = gc.Id,
                    ItemId = gc.ItemId,
                    Item = new ItemDTO
                    {
                        Id = gc.Item.Id,
                        Name = gc.Item.Name,
                        // Description = gc.Item.Description,
                        Price = gc.Item.Price,
                        // ImageUrl = gc.Item.ImageUrl,
                        // StoreUrl = gc.Item.StoreUrl,
                        WishListId = gc.Item.WishListId,
                        WishList = new WishListDTO
                        {
                            Id = gc.Item.WishList.Id,
                            Name = gc.Item.WishList.Name,
                            ListTypeId = gc.Item.WishList.ListTypeId,
                            UserId = gc.Item.WishList.UserId
                        }
                    },
                    UserId = gc.UserId
                }).ToList()
            };

            return Ok(userDto);
        }
        return NotFound();
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegistrationDTO registration)
    {
        var user = new IdentityUser
        {
            UserName = registration.UserName,
            Email = registration.Email
        };

        var password = Encoding
            .GetEncoding("iso-8859-1")
            .GetString(Convert.FromBase64String(registration.Password));

        var result = await _userManager.CreateAsync(user, password);
        if (result.Succeeded)
        {
            _dbContext.UserProfiles.Add(new UserProfile
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                IdentityUserId = user.Id,
            });
            _dbContext.SaveChanges();

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)

                };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity)).Wait();

            return Ok();
        }
        return StatusCode(500);
    }
}