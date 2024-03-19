using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class WishListCreateFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a08ec69-a79a-476e-949b-b16931b15bbb", "AQAAAAIAAYagAAAAEOPGDXkA4FMI/7eOy9g/zhgQmyDoj0YYXB6iL1hbv+819+G5FjsvU7mE4mGyCnQS0A==", "633986c0-b9fc-41c0-831c-8f7545bd34e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38862514-0cfb-4395-b603-e502d74ad081", "AQAAAAIAAYagAAAAEAhjNOavIZFixqI1Qo4SMJb9qqcRrd9Qg8wHv7w5N87i4WxcuXbq95isezv19+YpDQ==", "2e48a2d4-edca-4c1e-96b3-aa713b0702dd" });
        }
    }
}
