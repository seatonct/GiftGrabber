using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class ItemClaimed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiftClaims_ItemId",
                table: "GiftClaims");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34e2551c-4680-4b07-9999-2166d8298e82", "AQAAAAIAAYagAAAAELG95YnEcrLAT2HYZnUwWaSjD2SCSgpI2GGc4P3pmS5mYU3WnBE1vbJIendefHxqAQ==", "35e5b7b6-c6b3-4d86-bb9d-91b9b4ce7d8a" });

            migrationBuilder.CreateIndex(
                name: "IX_GiftClaims_ItemId",
                table: "GiftClaims",
                column: "ItemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiftClaims_ItemId",
                table: "GiftClaims");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e81f47-f5a9-4c2e-b78d-655f49e2759d", "AQAAAAIAAYagAAAAEB57CWv8fk1NqS7FOKp5u/MR+G38qu6fbzN7xIJ5wO5PYu3GsD8yubC0o1Ep0iKXCg==", "3f77e19c-846d-4e48-96a1-c9ea96cc4902" });

            migrationBuilder.CreateIndex(
                name: "IX_GiftClaims_ItemId",
                table: "GiftClaims",
                column: "ItemId");
        }
    }
}
