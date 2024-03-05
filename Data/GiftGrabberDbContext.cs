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

        modelBuilder.Entity<WishList>().HasData(new WishList[]
        {
            new WishList 
            {
                Id = 1,
                Name = "Bobby's Christmas List",
                ListTypeId = 1,
                UserId = 1,
                ForSelf = false
            },
            new WishList 
            {
                Id = 2,
                Name = "Hank's Birthday List",
                ListTypeId = 3,
                UserId = 1,
                ForSelf = false
            }
        });

        modelBuilder.Entity<Item>().HasData(new Item[]
        {
            new Item
            {
                Id = 1,
                Name = "Rubber Chicken",
                Description = "POPLAY Rubber Chicken/Squeeze Chicken, Decompressive/Vent Toy, Prank Novelty Toy for Kids, Adults, Dogs, Family Games,Keep Your Chicken Quiet",
                Price = 6.99M,
                ImageUrl = "https://m.media-amazon.com/images/I/41zxriQCZtL._AC_SY355_.jpg",
                StoreUrl = "https://www.amazon.com/POPLAY-Rubber-Chicken-Squeeze-Novelty/dp/B01LYW69OL/ref=sr_1_1_sspa?crid=551WRVV109O3&dib=eyJ2IjoiMSJ9.EA47TEPDHmtRTitfZo6Ymmk47o80yljjvfIKXvl3MiaMk3_m3K1MvuBlmtRnX7ozmKZjdF1uPaxOn5PgB7hB6DOc4_EBBlK_fbigRPF6zR8ME-CBBWrS4Ode6RikaYWqCKlQnSwYYgh-D8V040zzkXvdssIksaAtx56uKDeqapzYPUJNUN_c4kjjoZsbKZtYdUUxgYAFKq4ExAtcwGtOQoXiYd7n02Nlc58l-j4NEdsrlgbYgenA_QF9oY7AgUKByqrTQStgrWCXYr_vFDVj1OJfp0kgVxLrk5SJBCeRaDE.x6gZzsyYv_eHeMAVZLWQp3-rVnuyZHpMLsBQIbKGIbY&dib_tag=se&keywords=Rubber%2Bchicken&qid=1709660242&sprefix=rubber%2Bchicken%2Caps%2C105&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1",
                WishListId = 1
            },
            new Item
            {
                Id = 2,
                Name = "Whoopie Cushion",
                Description = "",
                Price = 14.99M,
                ImageUrl = "https://m.media-amazon.com/images/I/61OgnrR29tL._AC_SY355_.jpg",
                StoreUrl = "https://www.amazon.com/ArtCreativity-Inflating-Whoopie-Cushions-Stuffers/dp/B0BPDL87HN/ref=sr_1_1_sspa?crid=29Z7ONWASM4OE&dib=eyJ2IjoiMSJ9.UwTRV8y5LVQwz01cO4Y8uVWBzU-2PjMQEEK-3kJLZ6IaKWn4oP7XDf7qGUKsUu7T-BwkD87ZE-eXTlfLtPMMDQbQ-EmCcxlIu7F-CrDedX-buVCMo-sIP1XNRv9WxKrwfnF5w0D_QUJypKtyFspxDTyPYsmmwXjzvNXThWe9kvVTa7DcXli6srQkCVuWyu6er9ECM6k4PpMuHS6Woc7eNH_AaujuF26hTmSG2UhNb2aOIc89xpuDvi-Qw2l3wXQe0tnoncWdaTOuW5pu_Ek3QvPdcZdqzJ4xdyZTZnoT-_c.yF-sO1Jbz2qGPL62cwOF5yYN4Cc27s8N8aDlx_Ugguk&dib_tag=se&keywords=Whoopie+Cushion&qid=1709660591&sprefix=whoopie+cushion%2Caps%2C99&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                WishListId = 1
            },
            new Item
            {
                Id = 3,
                Name = "Tool Belt",
                Description = "19 Pocket Tool Belts with Quick Release Buckle- Heavy Duty Detachable & Adjustable Utility Belt,Work Apron for Men and Women,for Electrician,Carpenter,Construction Tool Belt,Gifts(Khaki)",
                Price = 0,
                ImageUrl = "https://m.media-amazon.com/images/I/71uq3xQrJdL._AC_SX425_.jpg",
                StoreUrl = "https://www.amazon.com/KOYYTO-Detachable-Electrician-Construction-Khaki/dp/B0C2CM3V3L/ref=sr_1_2_sspa?crid=AUHBP32OA4EK&dib=eyJ2IjoiMSJ9.YCsuBIegsn1EcYqjpjCH55egNo62OguDfC3rLuJUJ8S0duO6gUukIsyRPkIUtvv_4MghpY627cxQbNJiP8kMsnlSLGNk6NBWxqqqihn_Od7x64F_30ne7KWoV0oYMhp5Bdq_pEGKEMXP2Sj_j8vOBdWbnKlF4c3pDwBdaLjN3ZpDN9pq0x3P7nnXTkYL2qvt2FvYt6u9PZpyF1dBDN5SAFZIpv_3CtnsBkUB2WtIiOdvvYirXHXhmnUE8CdvhHP1BQB2lBUzYx0vZeyT8i4bKZdO2WcgWFYK2fGdrqDyF2o.9-T6ZIa8g_qu9Ca4AQlRC2asOGINr7fwvO3-Z7qmZvQ&dib_tag=se&keywords=tool+belt&qid=1709660729&sprefix=tool+%2Caps%2C111&sr=8-2-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                WishListId = 2
            },
            new Item
            {
                Id = 4,
                Name = "Clamps",
                Description = "Amazon Basics 6-Piece Trigger Clamp Set, 2 Pack of 4-Inch, 4 Pack of 6-Inch, Black/ Grey",
                Price = 22.98M,
                ImageUrl = "",
                StoreUrl = "https://www.amazon.com/AmazonBasics-6-Piece-Trigger-Clamp-Set/dp/B07ZTVY1PM/ref=sr_1_1_ffob_sspa?crid=9LX5S4EDMQWL&dib=eyJ2IjoiMSJ9.XAGONa1GeAf4MLtaidTcb07S3wCxMSsZDMQSJ-Z_OiKlI0zun1PFFhGyBHSzluXwXbbWrtCRQJhWQ-ukjvTMu9jHFi_LA7fYpzOu_w-H64TpGvM_tHG8nh8uRAANeURGR6QynaPWj5a38eSj1geqCB7lYtSHOWG72XWvmcIMHmQDdyMZ1IHt7TZ0iTHQ8idGzrJ_JxkpXvCQMTidB02zoUjR5RviLyceYrMPyQxYruEd_-IGLEtnRVrBHOcyxCxCBakBqmF7hn9qlOHA1KHCQk0q_9-CxtJEC4KzyOlcrYo.PnpOgqkdqfJwvrMPlynZxngn2LwGOJ8ZNUitXGA-HBk&dib_tag=se&keywords=clamps+for+woodworking&qid=1709660895&sprefix=clamps%2Caps%2C134&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                WishListId = 2
            },
            new Item
            {
                Id = 5,
                Name = "Fruit Pies",
                Description = "Cherry's My Favorite",
                Price = 10.00M,
                ImageUrl = "https://m.media-amazon.com/images/I/51nkUZ64-lL.jpg",
                StoreUrl = "",
                WishListId = 1
            }
        });

        modelBuilder.Entity<GiftClaim>().HasData(new GiftClaim[]
        {
            new GiftClaim 
            {
                Id = 1,
                ItemId = 1,
                UserId = 1
            },
            new GiftClaim 
            {
                Id = 2,
                ItemId = 3,
                UserId = 1,
            }
        });
    }
}