using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forgebase.Identity.Data.Migrations
{
    public partial class DataIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c69e806e-d911-4500-af30-1fbf2409d189", 0, "4f9316bb-fbd4-4e80-920f-44e5d065101e", new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.inverttriangle@hotmail.com", true, "Sysadmin", "@InvertTriangle", false, null, "ADMIN.INVERTTRIANGLE@HOTMAIL.COM", "ADMIN.INVERTTRIANGLE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPZ+W6om4bZ+fbIkz8Lti2ov10HL5HNhsI9C8A44FSZl/4MksxpHYS6Yaf55gf980Q==", "+9101234567890", true, "9e84634b-39ca-4d5f-9c78-c41810ea89a0", false, "admin.inverttriangle@hotmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c69e806e-d911-4500-af30-1fbf2409d189");
        }
    }
}
