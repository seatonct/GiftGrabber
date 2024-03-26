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
public class GiftClaimController : ControllerBase 
{
    private GiftGrabberDbContext _dbContext;
    

    public GiftClaimController(GiftGrabberDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok(_dbContext
                    .GiftClaims
                    .Select(gc => new GiftClaimDTO
                    {
                        Id = gc.Id,
                        ItemId = gc.ItemId,
                        Item = new ItemDTO
                        {
                            Id = gc.Item.Id,
                            Name = gc.Item.Name,
                        },
                        UserId = gc.UserId
                    })
                    .ToList());
    }

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
    {
        try
        {
            GiftClaim? giftClaim = _dbContext
                .GiftClaims
                .SingleOrDefault(gc => gc.Id == id);
            
            if (giftClaim == null)
            {
                return NotFound();
            }

            Item? item = _dbContext
                .Items
                .SingleOrDefault(i => i.Id == giftClaim.ItemId);
            
            giftClaim.Item.Id = item.Id;
            giftClaim.Item.Name = item.Name;
            
            return Ok(giftClaim);
        }

        catch
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
}