using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class OneMoreTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528ec0f1-52b5-4572-a081-9bb61473e7fc", "AQAAAAIAAYagAAAAEGsO2HqB5IJT1dABnSUZcFOLqXFRqO1Z1CV+hanJbo8wWQmWOtboD4jzD6zaTdjqBw==", "6862d9b3-c272-43cb-9aef-be75549fca68" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74543970-cd6d-48e7-a265-07d78c1637fb", "AQAAAAIAAYagAAAAEBSKLZL/aI3i9WmEgVXwoqpcC8vp/iOIvSF6BjPz4bTFyYZQ2T186wFABWsrRJvx5Q==", "3564bb73-ef37-42a2-9305-f91ee08528d5" });
        }
    }
}
