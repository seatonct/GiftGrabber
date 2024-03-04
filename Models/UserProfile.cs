using Microsoft.AspNetCore.Identity;

namespace GiftGrabber.Models;

public class UserProfile
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
    public List<WishList> WishLists { get; set; }
    public List<Claim> Claims { get; set; }
}