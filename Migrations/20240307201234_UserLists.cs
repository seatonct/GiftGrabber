using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class UserLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e93cbd8d-2657-4315-8556-49253dfcf902", "AQAAAAIAAYagAAAAEG48I/i4/wZk25QSc5ZLWBXk4kSrCbHu0/9LENJW94d3Blz50BLnSQAnuIrc0EWPNQ==", "33a84b4e-16ef-4a0c-ac47-01150ec8c5ed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87989b97-b43e-4b89-977e-4ce5bc7ae7c4", "AQAAAAIAAYagAAAAEA0+tg4TQXMbsv0+IwyqGiBaPWgI/tAOXRI3SnNd95NXuxdv4/deVTI8a878di87BA==", "4b7d26ac-851a-42f3-8428-977c0f3f62cb" });
        }
    }
}
