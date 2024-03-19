using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class WishList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_WishList_WishListId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_ListType_ListTypeId",
                table: "WishList");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_UserProfiles_UserId",
                table: "WishList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishList",
                table: "WishList");

            migrationBuilder.RenameTable(
                name: "WishList",
                newName: "WishLists");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_UserId",
                table: "WishLists",
                newName: "IX_WishLists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_ListTypeId",
                table: "WishLists",
                newName: "IX_WishLists_ListTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1548e22f-00c5-4419-8f50-5e580a26c222", "AQAAAAIAAYagAAAAEOqnuTqhpEbugb0cpGaYLhh+Tbi0Vcd1+MJQtTo3HOYQzCoZCiTTNPl6c+5nSk5hfA==", "ab749921-50ce-4640-8741-629a154aed88" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_WishLists_WishListId",
                table: "Item",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_ListType_ListTypeId",
                table: "WishLists",
                column: "ListTypeId",
                principalTable: "ListType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_UserProfiles_UserId",
                table: "WishLists",
                column: "UserId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_WishLists_WishListId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_ListType_ListTypeId",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_UserProfiles_UserId",
                table: "WishLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists");

            migrationBuilder.RenameTable(
                name: "WishLists",
                newName: "WishList");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_UserId",
                table: "WishList",
                newName: "IX_WishList_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ListTypeId",
                table: "WishList",
                newName: "IX_WishList_ListTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishList",
                table: "WishList",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87593c2-0055-42ec-b22b-ccd70791f42e", "AQAAAAIAAYagAAAAEBb57YdMLcR060zs9bBeL83nkz1RB9Pl+0xAE0V746vCF3iBWrW1FTmvANOiGR+VjA==", "7a2c3244-bc84-473a-aa8f-f5f9a25b4cab" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_WishList_WishListId",
                table: "Item",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_ListType_ListTypeId",
                table: "WishList",
                column: "ListTypeId",
                principalTable: "ListType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_UserProfiles_UserId",
                table: "WishList",
                column: "UserId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
