﻿// <auto-generated />
using System;
using GiftGrabber.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GiftGrabber.Migrations
{
    [DbContext(typeof(GiftGrabberDbContext))]
    [Migration("20240319154912_GetItems")]
    partial class GetItems
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GiftGrabber.Models.GiftClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("GiftClaim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 3,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("GiftGrabber.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("StoreUrl")
                        .HasColumnType("text");

                    b.Property<int>("WishListId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WishListId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "POPLAY Rubber Chicken/Squeeze Chicken, Decompressive/Vent Toy, Prank Novelty Toy for Kids, Adults, Dogs, Family Games,Keep Your Chicken Quiet",
                            ImageUrl = "https://m.media-amazon.com/images/I/41zxriQCZtL._AC_SY355_.jpg",
                            Name = "Rubber Chicken",
                            Price = 6.99m,
                            StoreUrl = "https://www.amazon.com/POPLAY-Rubber-Chicken-Squeeze-Novelty/dp/B01LYW69OL/ref=sr_1_1_sspa?crid=551WRVV109O3&dib=eyJ2IjoiMSJ9.EA47TEPDHmtRTitfZo6Ymmk47o80yljjvfIKXvl3MiaMk3_m3K1MvuBlmtRnX7ozmKZjdF1uPaxOn5PgB7hB6DOc4_EBBlK_fbigRPF6zR8ME-CBBWrS4Ode6RikaYWqCKlQnSwYYgh-D8V040zzkXvdssIksaAtx56uKDeqapzYPUJNUN_c4kjjoZsbKZtYdUUxgYAFKq4ExAtcwGtOQoXiYd7n02Nlc58l-j4NEdsrlgbYgenA_QF9oY7AgUKByqrTQStgrWCXYr_vFDVj1OJfp0kgVxLrk5SJBCeRaDE.x6gZzsyYv_eHeMAVZLWQp3-rVnuyZHpMLsBQIbKGIbY&dib_tag=se&keywords=Rubber%2Bchicken&qid=1709660242&sprefix=rubber%2Bchicken%2Caps%2C105&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1",
                            WishListId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            ImageUrl = "https://m.media-amazon.com/images/I/61OgnrR29tL._AC_SY355_.jpg",
                            Name = "Whoopie Cushion",
                            Price = 14.99m,
                            StoreUrl = "https://www.amazon.com/ArtCreativity-Inflating-Whoopie-Cushions-Stuffers/dp/B0BPDL87HN/ref=sr_1_1_sspa?crid=29Z7ONWASM4OE&dib=eyJ2IjoiMSJ9.UwTRV8y5LVQwz01cO4Y8uVWBzU-2PjMQEEK-3kJLZ6IaKWn4oP7XDf7qGUKsUu7T-BwkD87ZE-eXTlfLtPMMDQbQ-EmCcxlIu7F-CrDedX-buVCMo-sIP1XNRv9WxKrwfnF5w0D_QUJypKtyFspxDTyPYsmmwXjzvNXThWe9kvVTa7DcXli6srQkCVuWyu6er9ECM6k4PpMuHS6Woc7eNH_AaujuF26hTmSG2UhNb2aOIc89xpuDvi-Qw2l3wXQe0tnoncWdaTOuW5pu_Ek3QvPdcZdqzJ4xdyZTZnoT-_c.yF-sO1Jbz2qGPL62cwOF5yYN4Cc27s8N8aDlx_Ugguk&dib_tag=se&keywords=Whoopie+Cushion&qid=1709660591&sprefix=whoopie+cushion%2Caps%2C99&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                            WishListId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "19 Pocket Tool Belts with Quick Release Buckle- Heavy Duty Detachable & Adjustable Utility Belt,Work Apron for Men and Women,for Electrician,Carpenter,Construction Tool Belt,Gifts(Khaki)",
                            ImageUrl = "https://m.media-amazon.com/images/I/71uq3xQrJdL._AC_SX425_.jpg",
                            Name = "Tool Belt",
                            Price = 0m,
                            StoreUrl = "https://www.amazon.com/KOYYTO-Detachable-Electrician-Construction-Khaki/dp/B0C2CM3V3L/ref=sr_1_2_sspa?crid=AUHBP32OA4EK&dib=eyJ2IjoiMSJ9.YCsuBIegsn1EcYqjpjCH55egNo62OguDfC3rLuJUJ8S0duO6gUukIsyRPkIUtvv_4MghpY627cxQbNJiP8kMsnlSLGNk6NBWxqqqihn_Od7x64F_30ne7KWoV0oYMhp5Bdq_pEGKEMXP2Sj_j8vOBdWbnKlF4c3pDwBdaLjN3ZpDN9pq0x3P7nnXTkYL2qvt2FvYt6u9PZpyF1dBDN5SAFZIpv_3CtnsBkUB2WtIiOdvvYirXHXhmnUE8CdvhHP1BQB2lBUzYx0vZeyT8i4bKZdO2WcgWFYK2fGdrqDyF2o.9-T6ZIa8g_qu9Ca4AQlRC2asOGINr7fwvO3-Z7qmZvQ&dib_tag=se&keywords=tool+belt&qid=1709660729&sprefix=tool+%2Caps%2C111&sr=8-2-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                            WishListId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Amazon Basics 6-Piece Trigger Clamp Set, 2 Pack of 4-Inch, 4 Pack of 6-Inch, Black/ Grey",
                            ImageUrl = "",
                            Name = "Clamps",
                            Price = 22.98m,
                            StoreUrl = "https://www.amazon.com/AmazonBasics-6-Piece-Trigger-Clamp-Set/dp/B07ZTVY1PM/ref=sr_1_1_ffob_sspa?crid=9LX5S4EDMQWL&dib=eyJ2IjoiMSJ9.XAGONa1GeAf4MLtaidTcb07S3wCxMSsZDMQSJ-Z_OiKlI0zun1PFFhGyBHSzluXwXbbWrtCRQJhWQ-ukjvTMu9jHFi_LA7fYpzOu_w-H64TpGvM_tHG8nh8uRAANeURGR6QynaPWj5a38eSj1geqCB7lYtSHOWG72XWvmcIMHmQDdyMZ1IHt7TZ0iTHQ8idGzrJ_JxkpXvCQMTidB02zoUjR5RviLyceYrMPyQxYruEd_-IGLEtnRVrBHOcyxCxCBakBqmF7hn9qlOHA1KHCQk0q_9-CxtJEC4KzyOlcrYo.PnpOgqkdqfJwvrMPlynZxngn2LwGOJ8ZNUitXGA-HBk&dib_tag=se&keywords=clamps+for+woodworking&qid=1709660895&sprefix=clamps%2Caps%2C134&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1",
                            WishListId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cherry's My Favorite",
                            ImageUrl = "https://m.media-amazon.com/images/I/51nkUZ64-lL.jpg",
                            Name = "Fruit Pies",
                            Price = 10.00m,
                            StoreUrl = "",
                            WishListId = 1
                        });
                });

            modelBuilder.Entity("GiftGrabber.Models.ListType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ListType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Christmas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hanukkah"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Birthday"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bar/Bat Mitzvah"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Quinceañera"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Wedding Registry"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bridal Shower"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Honey-Do"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Housewarming"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Baby Shower"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("GiftGrabber.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Admina",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            LastName = "Strator"
                        });
                });

            modelBuilder.Entity("GiftGrabber.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ForSelf")
                        .HasColumnType("boolean");

                    b.Property<int>("ListTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ListTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("WishLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ForSelf = false,
                            ListTypeId = 1,
                            Name = "Bobby's Christmas List",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ForSelf = false,
                            ListTypeId = 3,
                            Name = "Hank's Birthday List",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            Name = "Admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "61a9e3e5-b640-4f06-b2a7-7b3752a15c54",
                            Email = "admina@strator.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEE589Z0FQCj55woyT3YxNo5ZsIF67uQt/2eB7/yTrvtzUhfHsPzvS6i72C+H9eCNRg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2d6172db-1f76-4da9-abee-da672f2f86f4",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GiftGrabber.Models.GiftClaim", b =>
                {
                    b.HasOne("GiftGrabber.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftGrabber.Models.UserProfile", "User")
                        .WithMany("GiftClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GiftGrabber.Models.Item", b =>
                {
                    b.HasOne("GiftGrabber.Models.WishList", "WishList")
                        .WithMany("Items")
                        .HasForeignKey("WishListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("GiftGrabber.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("GiftGrabber.Models.WishList", b =>
                {
                    b.HasOne("GiftGrabber.Models.ListType", "ListType")
                        .WithMany()
                        .HasForeignKey("ListTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftGrabber.Models.UserProfile", "User")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GiftGrabber.Models.UserProfile", b =>
                {
                    b.Navigation("GiftClaims");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("GiftGrabber.Models.WishList", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
