using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class GetClaimsGet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaim_Items_ItemId",
                table: "GiftClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaim_UserProfiles_UserId",
                table: "GiftClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GiftClaim",
                table: "GiftClaim");

            migrationBuilder.RenameTable(
                name: "GiftClaim",
                newName: "GiftClaims");

            migrationBuilder.RenameIndex(
                name: "IX_GiftClaim_UserId",
                table: "GiftClaims",
                newName: "IX_GiftClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GiftClaim_ItemId",
                table: "GiftClaims",
                newName: "IX_GiftClaims_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GiftClaims",
                table: "GiftClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb1097dd-4f3f-4c0f-8b3e-3dabbe382f0f", "AQAAAAIAAYagAAAAEADgQIEwapJentLcg5F32p71WloFqgvcFiWVWOUP5yrcpcBKQ/veD+5RuPXs4BKkiQ==", "ff00df1e-6276-45e5-b586-3aa05d07cd12" });

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaims_Items_ItemId",
                table: "GiftClaims",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaims_UserProfiles_UserId",
                table: "GiftClaims",
                column: "UserId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaims_Items_ItemId",
                table: "GiftClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_GiftClaims_UserProfiles_UserId",
                table: "GiftClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GiftClaims",
                table: "GiftClaims");

            migrationBuilder.RenameTable(
                name: "GiftClaims",
                newName: "GiftClaim");

            migrationBuilder.RenameIndex(
                name: "IX_GiftClaims_UserId",
                table: "GiftClaim",
                newName: "IX_GiftClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GiftClaims_ItemId",
                table: "GiftClaim",
                newName: "IX_GiftClaim_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GiftClaim",
                table: "GiftClaim",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6db148e-1bf2-4b40-938a-640350096eba", "AQAAAAIAAYagAAAAEG10rBaHDKtQXklEaXMJGSbO7Ip6xh/T9FCwwD9un7PN7LyQbwSEzcL2D+4A/pcj/Q==", "cad84e37-357c-418a-8b0c-52d84520d167" });

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaim_Items_ItemId",
                table: "GiftClaim",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiftClaim_UserProfiles_UserId",
                table: "GiftClaim",
                column: "UserId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
