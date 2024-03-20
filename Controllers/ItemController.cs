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
}