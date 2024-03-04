namespace GiftGrabber.Models;

public class Claim
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public int UserId { get; set; }
    public UserProfile User { get; set; }
}