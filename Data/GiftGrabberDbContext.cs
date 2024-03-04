using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GiftGrabber.Models;
using Microsoft.AspNetCore.Identity;

namespace GiftGrabber.Data;
public class GiftGrabberDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    public DbSet<UserProfile> UserProfiles { get; set; }

    public GiftGrabberDbContext(DbContextOptions<GiftGrabberDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            Name = "Admin",
            NormalizedName = "admin"
        });

        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            UserName = "Administrator",
            Email = "admina@strator.comx",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
        });
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        {
            Id = 1,
            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            FirstName = "Admina",
            LastName = "Strator",
        });

        modelBuilder.Entity<ListType>().HasData(new ListType[]
        {
            new ListType {Id = 1, Name = "Christmas"},
            new ListType {Id = 2, Name = "Hanukkah"},
            new ListType {Id = 3, Name = "Birthday"},
            new ListType {Id = 4, Name = "Bar/Bat Mitzvah"},
            new ListType {Id = 5, Name = "Quinceañera"},
            new ListType {Id = 6, Name = "Wedding Registry"},
            new ListType {Id = 7, Name = "Briday Shower"},
            new ListType {Id = 8, Name = "Honey-Do"},
            new ListType {Id = 9, Name = "Housewarming"},
            new ListType {Id = 10, Name = "Baby Shower"},
            new ListType {Id = 11, Name = "Other"}
        });
    }
}