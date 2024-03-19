using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GiftGrabber.Data;
using Microsoft.EntityFrameworkCore;
using GiftGrabber.Models;
using GiftGrabber.Models.DTOs;
using System.Reflection.Metadata.Ecma335;

namespace GiftGrabber.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WishListController : ControllerBase
{
    private GiftGrabberDbContext _dbContext;
    private UserManager<IdentityUser> _userManager;
    

    public WishListController(GiftGrabberDbContext context, UserManager<IdentityUser> userManager)
    {
        _dbContext = context;
        _userManager = userManager;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get([FromQuery] string? userName)
    {
        try
        {
            if (!string.IsNullOrEmpty(userName))
            {
                var userLists =_dbContext
                    .WishLists
                    .Include(w => w.User)
                    .Select(w => new WishListDTO
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
                            User = new UserProfileDTO
                            {
                                FirstName = w.User.FirstName,
                                LastName = w.User.LastName
                            },
                            ForSelf = w.ForSelf
                    })
                    .Where(w => w.User.IdentityUser.UserName == userName)
                    .ToList();

                return Ok(userLists);
            } 
            else 
            {
                return Ok(_dbContext
                    .WishLists
                    .Select(w => new WishListDTO
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
                    })
                    .ToList());
            }
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
    {
        try
        {
            WishList? wishList = _dbContext
                .WishLists
                .SingleOrDefault(w => w.Id == id);
            
            if (wishList == null)
            {
                return NotFound();
            }
            
            return Ok(wishList);
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpPost]
    [Authorize]
    public IActionResult CreateWishList(WishList wishList)
    {
        try
        {
            _dbContext.WishLists.Add(wishList);
            _dbContext.SaveChanges();
            return Created($"/api/wishlist/{wishList.Id}", wishList);
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult UpdateWishList(WishList wishList, int id)
    {
        try
        {
            var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var profile = _dbContext.UserProfiles.SingleOrDefault(up => up.IdentityUserId == identityUserId);
            WishList wishListToUpdate = _dbContext.WishLists.SingleOrDefault(wl => wl.Id == id);

            if (wishListToUpdate == null)
            {
                return NotFound();
            }
            else if (id != wishList.Id)
            {
                return BadRequest();
            }

            wishListToUpdate.Name = wishList.Name;
            wishListToUpdate.ListTypeId = wishList.ListTypeId;
            wishListToUpdate.UserId = wishList.UserId;
            wishListToUpdate.ForSelf = wishList.ForSelf;

            _dbContext.SaveChanges();

            return NoContent();
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult DeleteWishList(int id)
    {
        try
        {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var profile = _dbContext.UserProfiles.SingleOrDefault(up => up.IdentityUserId == identityUserId);
        WishList wishList = _dbContext.WishLists.SingleOrDefault(wl => wl.Id == id);

        if (wishList == null)
        {
            return NotFound();
        }
        else if (wishList.UserId != profile.Id)
        {
            return Unauthorized();
        }

        _dbContext.WishLists.Remove(wishList);
        _dbContext.SaveChanges();

        return NoContent();
        }
        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
}