using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class CreateWishListDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "131fc980-9a2f-400c-9db3-cdef3aa7f796", "AQAAAAIAAYagAAAAEF62nwp63b7w5AVLZf6l9cFt3mfXdokt1QNa91L8I5NI9cuBzJGxVi7FTfEzABsgDQ==", "ad4e8ed0-68c9-403c-a7d3-e13a2908f09e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a08ec69-a79a-476e-949b-b16931b15bbb", "AQAAAAIAAYagAAAAEOPGDXkA4FMI/7eOy9g/zhgQmyDoj0YYXB6iL1hbv+819+G5FjsvU7mE4mGyCnQS0A==", "633986c0-b9fc-41c0-831c-8f7545bd34e2" });
        }
    }
}
