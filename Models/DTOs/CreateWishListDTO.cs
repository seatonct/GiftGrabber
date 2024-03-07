using System.ComponentModel;

namespace GiftGrabber.Models.DTOs;

public class CreateWishListDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ListTypeId { get; set; }
    public int UserId { get; set; }
    public Boolean ForSelf { get; set; }
}