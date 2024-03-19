using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class RemovedNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ef08e1-d92f-4436-a9cd-c14ba88dff7e", "AQAAAAIAAYagAAAAECM1+H57/y67g3w0Tx6X9sU9M+LBbtEwgy+NsmVCidkEo3ZuV57/yFNcJtnLWE6jaw==", "ded82fa5-7b94-46ec-a664-6f72b178b98f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e93cbd8d-2657-4315-8556-49253dfcf902", "AQAAAAIAAYagAAAAEG48I/i4/wZk25QSc5ZLWBXk4kSrCbHu0/9LENJW94d3Blz50BLnSQAnuIrc0EWPNQ==", "33a84b4e-16ef-4a0c-ac47-01150ec8c5ed" });
        }
    }
}
