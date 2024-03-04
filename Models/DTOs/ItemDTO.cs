namespace GiftGrabber.Models.DTOs;

public class ItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? ImageUrl { get; set;}
    public string? StoreUrl { get; set;}
    public int WishListId {get; set;}
    public WishListDTO WishList { get; set; }
}