using Microsoft.AspNetCore.Identity;

namespace GiftGrabber.Models;

public class UserProfile
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public string IdentityUserId { get; set; }

    public IdentityUser IdentityUser { get; set; }
}