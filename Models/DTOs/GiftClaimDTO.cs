namespace GiftGrabber.Models.DTOs;

public class GiftClaimDTO
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public ItemDTO? Item { get; set; }
    public int UserId { get; set; }
    public UserProfileDTO? User { get; set; }
}