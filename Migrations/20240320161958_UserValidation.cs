using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class UserValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6db148e-1bf2-4b40-938a-640350096eba", "AQAAAAIAAYagAAAAEG10rBaHDKtQXklEaXMJGSbO7Ip6xh/T9FCwwD9un7PN7LyQbwSEzcL2D+4A/pcj/Q==", "cad84e37-357c-418a-8b0c-52d84520d167" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95033035-596d-4a90-acae-c693e4887c62", "AQAAAAIAAYagAAAAENiQas/OqQiTwm/VGDkuIvMVvPCrbJj47JrZlTVgyfDiBxBX3Akis5lO1sHOTSB2aQ==", "b74d4880-5103-44b2-bb36-59c74c837c34" });
        }
    }
}
