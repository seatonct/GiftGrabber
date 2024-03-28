using System.ComponentModel;

namespace GiftGrabber.Models.DTOs;

public class WishListDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ListTypeId { get; set; }
    public ListTypeDTO? ListType {get; set;}
    public int UserId { get; set; }
    public UserProfileDTO? User { get; set; }
    public bool ForSelf { get; set; }
    public List<ItemDTO>? Items { get; set; }
}