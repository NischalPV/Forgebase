using Microsoft.EntityFrameworkCore.Migrations;

namespace Forgebase.Identity.Data.Migrations.Configuration
{
    public partial class DataUpdateClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResourceScopes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Scope",
                value: "Masterdata");

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Masterdata Service", "Masterdata" });

            migrationBuilder.UpdateData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Masterdata API Scope", "Masterdata" });

            migrationBuilder.UpdateData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Scope",
                value: "Masterdata");

            migrationBuilder.UpdateData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Scope",
                value: "Masterdata");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "ClientName" },
                values: new object[] { "forgebase-masterdata", "Forgebase Masterdata Swagger UI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResourceScopes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Scope",
                value: "Manufacturer");

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Manufacturer Service", "Manufacturer" });

            migrationBuilder.UpdateData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Manufacturer API Scope", "Manufacturer" });

            migrationBuilder.UpdateData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Scope",
                value: "Manufacturer");

            migrationBuilder.UpdateData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Scope",
                value: "Manufacturer");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "ClientName" },
                values: new object[] { "forgebase-api", "Forgebase Api Swagger UI" });
        }
    }
}
