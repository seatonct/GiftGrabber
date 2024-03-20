using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class CreateItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95033035-596d-4a90-acae-c693e4887c62", "AQAAAAIAAYagAAAAENiQas/OqQiTwm/VGDkuIvMVvPCrbJj47JrZlTVgyfDiBxBX3Akis5lO1sHOTSB2aQ==", "b74d4880-5103-44b2-bb36-59c74c837c34" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bae496df-5173-4a5c-aada-42c69bfd041f", "AQAAAAIAAYagAAAAEKFqZTSm2vwKxO0sZReqDSTIqAJ16+16bFQzkfHJalcSHhCV4twfpjdQ2RnBS/EtRw==", "27be0c7b-a549-4046-b68d-1dd0b4bf69ad" });
        }
    }
}
