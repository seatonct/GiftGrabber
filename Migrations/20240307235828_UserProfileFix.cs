using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class UserProfileFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74543970-cd6d-48e7-a265-07d78c1637fb", "AQAAAAIAAYagAAAAEBSKLZL/aI3i9WmEgVXwoqpcC8vp/iOIvSF6BjPz4bTFyYZQ2T186wFABWsrRJvx5Q==", "3564bb73-ef37-42a2-9305-f91ee08528d5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ef08e1-d92f-4436-a9cd-c14ba88dff7e", "AQAAAAIAAYagAAAAECM1+H57/y67g3w0Tx6X9sU9M+LBbtEwgy+NsmVCidkEo3ZuV57/yFNcJtnLWE6jaw==", "ded82fa5-7b94-46ec-a664-6f72b178b98f" });
        }
    }
}
