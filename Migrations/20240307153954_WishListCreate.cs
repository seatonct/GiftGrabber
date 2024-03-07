using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class WishListCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38862514-0cfb-4395-b603-e502d74ad081", "AQAAAAIAAYagAAAAEAhjNOavIZFixqI1Qo4SMJb9qqcRrd9Qg8wHv7w5N87i4WxcuXbq95isezv19+YpDQ==", "2e48a2d4-edca-4c1e-96b3-aa713b0702dd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1548e22f-00c5-4419-8f50-5e580a26c222", "AQAAAAIAAYagAAAAEOqnuTqhpEbugb0cpGaYLhh+Tbi0Vcd1+MJQtTo3HOYQzCoZCiTTNPl6c+5nSk5hfA==", "ab749921-50ce-4640-8741-629a154aed88" });
        }
    }
}
