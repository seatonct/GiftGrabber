using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class GetItemById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bae496df-5173-4a5c-aada-42c69bfd041f", "AQAAAAIAAYagAAAAEKFqZTSm2vwKxO0sZReqDSTIqAJ16+16bFQzkfHJalcSHhCV4twfpjdQ2RnBS/EtRw==", "27be0c7b-a549-4046-b68d-1dd0b4bf69ad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61a9e3e5-b640-4f06-b2a7-7b3752a15c54", "AQAAAAIAAYagAAAAEE589Z0FQCj55woyT3YxNo5ZsIF67uQt/2eB7/yTrvtzUhfHsPzvS6i72C+H9eCNRg==", "2d6172db-1f76-4da9-abee-da672f2f86f4" });
        }
    }
}
