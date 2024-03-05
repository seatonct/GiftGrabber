using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class BasicData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ListTypeId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ForSelf = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishList_ListType_ListTypeId",
                        column: x => x.ListTypeId,
                        principalTable: "ListType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishList_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    StoreUrl = table.Column<string>(type: "text", nullable: true),
                    WishListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_WishList_WishListId",
                        column: x => x.WishListId,
                        principalTable: "WishList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiftClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiftClaim_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiftClaim_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87593c2-0055-42ec-b22b-ccd70791f42e", "AQAAAAIAAYagAAAAEBb57YdMLcR060zs9bBeL83nkz1RB9Pl+0xAE0V746vCF3iBWrW1FTmvANOiGR+VjA==", "7a2c3244-bc84-473a-aa8f-f5f9a25b4cab" });

            migrationBuilder.InsertData(
                table: "ListType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Christmas" },
                    { 2, "Hanukkah" },
                    { 3, "Birthday" },
                    { 4, "Bar/Bat Mitzvah" },
                    { 5, "Quinceañera" },
                    { 6, "Wedding Registry" },
                    { 7, "Briday Shower" },
                    { 8, "Honey-Do" },
                    { 9, "Housewarming" },
                    { 10, "Baby Shower" },
                    { 11, "Other" }
                });

            migrationBuilder.InsertData(
                table: "WishList",
                columns: new[] { "Id", "ForSelf", "ListTypeId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, false, 1, "Bobby's Christmas List", 1 },
                    { 2, false, 3, "Hank's Birthday List", 1 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "StoreUrl", "WishListId" },
                values: new object[,]
                {
                    { 1, "POPLAY Rubber Chicken/Squeeze Chicken, Decompressive/Vent Toy, Prank Novelty Toy for Kids, Adults, Dogs, Family Games,Keep Your Chicken Quiet", "https://m.media-amazon.com/images/I/41zxriQCZtL._AC_SY355_.jpg", "Rubber Chicken", 6.99m, "https://www.amazon.com/POPLAY-Rubber-Chicken-Squeeze-Novelty/dp/B01LYW69OL/ref=sr_1_1_sspa?crid=551WRVV109O3&dib=eyJ2IjoiMSJ9.EA47TEPDHmtRTitfZo6Ymmk47o80yljjvfIKXvl3MiaMk3_m3K1MvuBlmtRnX7ozmKZjdF1uPaxOn5PgB7hB6DOc4_EBBlK_fbigRPF6zR8ME-CBBWrS4Ode6RikaYWqCKlQnSwYYgh-D8V040zzkXvdssIksaAtx56uKDeqapzYPUJNUN_c4kjjoZsbKZtYdUUxgYAFKq4ExAtcwGtOQoXiYd7n02Nlc58l-j4NEdsrlgbYgenA_QF9oY7AgUKByqrTQStgrWCXYr_vFDVj1OJfp0kgVxLrk5SJBCeRaDE.x6gZzsyYv_eHeMAVZLWQp3-rVnuyZHpMLsBQIbKGIbY&dib_tag=se&keywords=Rubber%2Bchicken&qid=1709660242&sprefix=rubber%2Bchicken%2Caps%2C105&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1", 1 },
                    { 2, "", "https://m.media-amazon.com/images/I/61OgnrR29tL._AC_SY355_.jpg", "Whoopie Cushion", 14.99m, "https://www.amazon.com/ArtCreativity-Inflating-Whoopie-Cushions-Stuffers/dp/B0BPDL87HN/ref=sr_1_1_sspa?crid=29Z7ONWASM4OE&dib=eyJ2IjoiMSJ9.UwTRV8y5LVQwz01cO4Y8uVWBzU-2PjMQEEK-3kJLZ6IaKWn4oP7XDf7qGUKsUu7T-BwkD87ZE-eXTlfLtPMMDQbQ-EmCcxlIu7F-CrDedX-buVCMo-sIP1XNRv9WxKrwfnF5w0D_QUJypKtyFspxDTyPYsmmwXjzvNXThWe9kvVTa7DcXli6srQkCVuWyu6er9ECM6k4PpMuHS6Woc7eNH_AaujuF26hTmSG2UhNb2aOIc89xpuDvi-Qw2l3wXQe0tnoncWdaTOuW5pu_Ek3QvPdcZdqzJ4xdyZTZnoT-_c.yF-sO1Jbz2qGPL62cwOF5yYN4Cc27s8N8aDlx_Ugguk&dib_tag=se&keywords=Whoopie+Cushion&qid=1709660591&sprefix=whoopie+cushion%2Caps%2C99&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1", 1 },
                    { 3, "19 Pocket Tool Belts with Quick Release Buckle- Heavy Duty Detachable & Adjustable Utility Belt,Work Apron for Men and Women,for Electrician,Carpenter,Construction Tool Belt,Gifts(Khaki)", "https://m.media-amazon.com/images/I/71uq3xQrJdL._AC_SX425_.jpg", "Tool Belt", 0m, "https://www.amazon.com/KOYYTO-Detachable-Electrician-Construction-Khaki/dp/B0C2CM3V3L/ref=sr_1_2_sspa?crid=AUHBP32OA4EK&dib=eyJ2IjoiMSJ9.YCsuBIegsn1EcYqjpjCH55egNo62OguDfC3rLuJUJ8S0duO6gUukIsyRPkIUtvv_4MghpY627cxQbNJiP8kMsnlSLGNk6NBWxqqqihn_Od7x64F_30ne7KWoV0oYMhp5Bdq_pEGKEMXP2Sj_j8vOBdWbnKlF4c3pDwBdaLjN3ZpDN9pq0x3P7nnXTkYL2qvt2FvYt6u9PZpyF1dBDN5SAFZIpv_3CtnsBkUB2WtIiOdvvYirXHXhmnUE8CdvhHP1BQB2lBUzYx0vZeyT8i4bKZdO2WcgWFYK2fGdrqDyF2o.9-T6ZIa8g_qu9Ca4AQlRC2asOGINr7fwvO3-Z7qmZvQ&dib_tag=se&keywords=tool+belt&qid=1709660729&sprefix=tool+%2Caps%2C111&sr=8-2-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1", 2 },
                    { 4, "Amazon Basics 6-Piece Trigger Clamp Set, 2 Pack of 4-Inch, 4 Pack of 6-Inch, Black/ Grey", "", "Clamps", 22.98m, "https://www.amazon.com/AmazonBasics-6-Piece-Trigger-Clamp-Set/dp/B07ZTVY1PM/ref=sr_1_1_ffob_sspa?crid=9LX5S4EDMQWL&dib=eyJ2IjoiMSJ9.XAGONa1GeAf4MLtaidTcb07S3wCxMSsZDMQSJ-Z_OiKlI0zun1PFFhGyBHSzluXwXbbWrtCRQJhWQ-ukjvTMu9jHFi_LA7fYpzOu_w-H64TpGvM_tHG8nh8uRAANeURGR6QynaPWj5a38eSj1geqCB7lYtSHOWG72XWvmcIMHmQDdyMZ1IHt7TZ0iTHQ8idGzrJ_JxkpXvCQMTidB02zoUjR5RviLyceYrMPyQxYruEd_-IGLEtnRVrBHOcyxCxCBakBqmF7hn9qlOHA1KHCQk0q_9-CxtJEC4KzyOlcrYo.PnpOgqkdqfJwvrMPlynZxngn2LwGOJ8ZNUitXGA-HBk&dib_tag=se&keywords=clamps+for+woodworking&qid=1709660895&sprefix=clamps%2Caps%2C134&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1", 2 },
                    { 5, "Cherry's My Favorite", "https://m.media-amazon.com/images/I/51nkUZ64-lL.jpg", "Fruit Pies", 10.00m, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "GiftClaim",
                columns: new[] { "Id", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiftClaim_ItemId",
                table: "GiftClaim",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftClaim_UserId",
                table: "GiftClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_WishListId",
                table: "Item",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_ListTypeId",
                table: "WishList",
                column: "ListTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserId",
                table: "WishList",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftClaim");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "ListType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c49bdb2-c2f5-4bcf-af78-e9b44ec0bf27", "AQAAAAIAAYagAAAAEHFCJimbp6Qo976Vn3Hg5zCKXH/thxIfCtrayrrcFa63IwPmNE6akQwa1kyNu8c+OA==", "bd403d9a-c821-4d39-b009-16797f36b3c8" });
        }
    }
}
