using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class FixMisspelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e81f47-f5a9-4c2e-b78d-655f49e2759d", "AQAAAAIAAYagAAAAEB57CWv8fk1NqS7FOKp5u/MR+G38qu6fbzN7xIJ5wO5PYu3GsD8yubC0o1Ep0iKXCg==", "3f77e19c-846d-4e48-96a1-c9ea96cc4902" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb32e6d8-8a14-4c56-9afa-713030063e1d", "AQAAAAIAAYagAAAAEJGkNFvt97kYavTM3/jCgpYJCsOqy57GaV04naxH1ffmGIfTXSdPnIQybzW2j6JXRg==", "bb3e20ca-7512-4bee-bcee-fea4a53aedbe" });
        }
    }
}
