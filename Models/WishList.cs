using System.ComponentModel;

namespace GiftGrabber.Models;

public class WishList
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ListTypeId { get; set; }
    public ListType ListType {get; set;}
    public int UserId { get; set; }
    public UserProfile User { get; set; }
    public Boolean ForSelf { get; set; }
    public List<Item> Items { get; set; }
}