using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftGrabber.Migrations
{
    /// <inheritdoc />
    public partial class UserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cde90e3-0b63-4ffb-8ec5-374446238d58", "AQAAAAIAAYagAAAAEHuZb/z3qj5uV1Ex8NLDfQvHNboFAuWf40ZCZxxvoVf7nISpXPdCorLHWhMM616Xgw==", "4870a79d-1de7-4fc7-8425-700fd9970b46" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528ec0f1-52b5-4572-a081-9bb61473e7fc", "AQAAAAIAAYagAAAAEGsO2HqB5IJT1dABnSUZcFOLqXFRqO1Z1CV+hanJbo8wWQmWOtboD4jzD6zaTdjqBw==", "6862d9b3-c272-43cb-9aef-be75549fca68" });
        }
    }
}
