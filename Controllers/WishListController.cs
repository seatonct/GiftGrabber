using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GiftGrabber.Data;
using Microsoft.EntityFrameworkCore;
using GiftGrabber.Models;
using GiftGrabber.Models.DTOs;

namespace GiftGrabber.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WishListController : ControllerBase
{
    private GiftGrabberDbContext _dbContext;

    public WishListController(GiftGrabberDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get()
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

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
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

    [HttpPost]
    [Authorize]
    public IActionResult CreateWishList([FromBody] CreateWishListDTO newWishList)
    {
        var wishList = new WishList
        {
            Name = newWishList.Name,
            ListTypeId = newWishList.ListTypeId,
            UserId = newWishList.UserId,
            ForSelf = newWishList.ForSelf
        }; 
        _dbContext.WishLists.Add(wishList);
        _dbContext.SaveChanges();
        return Created($"/api/wishlist/{wishList.Id}", wishList);
    }
}