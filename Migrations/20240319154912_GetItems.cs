using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class GetItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaim_Item_ItemId",
                table: "GiftClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_WishLists_WishListId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_WishListId",
                table: "Items",
                newName: "IX_Items_WishListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61a9e3e5-b640-4f06-b2a7-7b3752a15c54", "AQAAAAIAAYagAAAAEE589Z0FQCj55woyT3YxNo5ZsIF67uQt/2eB7/yTrvtzUhfHsPzvS6i72C+H9eCNRg==", "2d6172db-1f76-4da9-abee-da672f2f86f4" });

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaim_Items_ItemId",
                table: "GiftClaim",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_WishLists_WishListId",
                table: "Items",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaim_Items_ItemId",
                table: "GiftClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_WishLists_WishListId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_WishListId",
                table: "Item",
                newName: "IX_Item_WishListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cde90e3-0b63-4ffb-8ec5-374446238d58", "AQAAAAIAAYagAAAAEHuZb/z3qj5uV1Ex8NLDfQvHNboFAuWf40ZCZxxvoVf7nISpXPdCorLHWhMM616Xgw==", "4870a79d-1de7-4fc7-8425-700fd9970b46" });

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaim_Item_ItemId",
                table: "GiftClaim",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_WishLists_WishListId",
                table: "Item",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
