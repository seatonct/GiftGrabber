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
public class ItemController : ControllerBase
{
    private GiftGrabberDbContext _dbContext;
    

    public ItemController(GiftGrabberDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok(_dbContext
                    .Items
                    .Select(i => new ItemDTO
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Description = i.Description,
                        Price = i.Price,
                        ImageUrl = i.ImageUrl,
                        StoreUrl = i.StoreUrl,
                        WishListId = i.WishListId,
                        WishList = new WishListDTO
                        {
                            Id = i.WishList.Id,
                            Name = i.WishList.Name
                        }
                    })
                    .ToList());
    }

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
    {
        try
        {
            Item? item = _dbContext
                .Items
                .SingleOrDefault(i => i.Id == id);
            
            if (item == null)
            {
                return NotFound();
            }
            
            return Ok(item);
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpPost]
    [Authorize]
    public IActionResult CreateItem(Item item)
    {
        try
        {
            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();
            return Created($"/api/Item/{item.Id}", item);
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult UpdateItem(Item item, int id)
    {
        try
        {
            var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var profile = _dbContext.UserProfiles.SingleOrDefault(up => up.IdentityUserId == identityUserId);
            Item? itemToUpdate = _dbContext.Items.SingleOrDefault(i => i.Id == id);

            // Add user validation handling.
            if (itemToUpdate == null)
            {
                return NotFound();
            }
            else if (id != item.Id)
            {
                return BadRequest();
            }

            itemToUpdate.Name = item.Name;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Price = item.Price;
            itemToUpdate.ImageUrl = item.ImageUrl;
            itemToUpdate.StoreUrl = item.StoreUrl;
            itemToUpdate.WishListId = item.WishListId;

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
    public IActionResult DeleteItem(int id)
    {
        try
        {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var profile = _dbContext.UserProfiles.SingleOrDefault(up => up.IdentityUserId == identityUserId);
        Item? item = _dbContext.Items.SingleOrDefault(i => i.Id == id);

        if (item == null)
        {
            return NotFound();
        }
        else if (item.WishList.UserId != profile.Id)
        {
            return Unauthorized();
        }

        _dbContext.Items.Remove(item);
        _dbContext.SaveChanges();

        return NoContent();
        }
        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
}