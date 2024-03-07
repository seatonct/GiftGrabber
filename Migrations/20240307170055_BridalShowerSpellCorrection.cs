using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class BridalShowerSpellCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87989b97-b43e-4b89-977e-4ce5bc7ae7c4", "AQAAAAIAAYagAAAAEA0+tg4TQXMbsv0+IwyqGiBaPWgI/tAOXRI3SnNd95NXuxdv4/deVTI8a878di87BA==", "4b7d26ac-851a-42f3-8428-977c0f3f62cb" });

            migrationBuilder.UpdateData(
                table: "ListType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Bridal Shower");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "131fc980-9a2f-400c-9db3-cdef3aa7f796", "AQAAAAIAAYagAAAAEF62nwp63b7w5AVLZf6l9cFt3mfXdokt1QNa91L8I5NI9cuBzJGxVi7FTfEzABsgDQ==", "ad4e8ed0-68c9-403c-a7d3-e13a2908f09e" });

            migrationBuilder.UpdateData(
                table: "ListType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Briday Shower");
        }
    }
}
