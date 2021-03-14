using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forgebase.Identity.Data.Migrations.Configuration
{
    public partial class DataClientsApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:5003");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5003/");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "http://localhost:5003/");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClientUri",
                value: "http://localhost:5003");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AbsoluteRefreshTokenLifetime", "AccessTokenLifetime", "AccessTokenType", "AllowAccessTokensViaBrowser", "AllowOfflineAccess", "AllowPlainTextPkce", "AllowRememberConsent", "AllowedIdentityTokenSigningAlgorithms", "AlwaysIncludeUserClaimsInIdToken", "AlwaysSendClientClaims", "AuthorizationCodeLifetime", "BackChannelLogoutSessionRequired", "BackChannelLogoutUri", "ClientClaimsPrefix", "ClientId", "ClientName", "ClientUri", "ConsentLifetime", "Created", "Description", "DeviceCodeLifetime", "EnableLocalLogin", "Enabled", "FrontChannelLogoutSessionRequired", "FrontChannelLogoutUri", "IdentityTokenLifetime", "IncludeJwtId", "LastAccessed", "LogoUri", "NonEditable", "PairWiseSubjectSalt", "ProtocolType", "RefreshTokenExpiration", "RefreshTokenUsage", "RequireClientSecret", "RequireConsent", "RequirePkce", "RequireRequestObject", "SlidingRefreshTokenLifetime", "UpdateAccessTokenClaimsOnRefresh", "Updated", "UserCodeType", "UserSsoLifetime" },
                values: new object[] { 2, 2592000, 3600, 0, true, false, false, true, null, false, false, 300, true, null, "client_", "forgebase-api", "Forgebase Api Swagger UI", null, null, new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870), null, 300, true, true, true, null, 300, true, null, null, false, null, "oidc", 1, 1, true, false, true, false, 1296000, false, null, null, null });

            migrationBuilder.InsertData(
                table: "ClientGrantTypes",
                columns: new[] { "Id", "ClientId", "GrantType" },
                values: new object[] { 2, 2, "implicit" });

            migrationBuilder.InsertData(
                table: "ClientPostLogoutRedirectUris",
                columns: new[] { "Id", "ClientId", "PostLogoutRedirectUri" },
                values: new object[] { 2, 2, "http://localhost:5002/swagger/" });

            migrationBuilder.InsertData(
                table: "ClientRedirectUris",
                columns: new[] { "Id", "ClientId", "RedirectUri" },
                values: new object[] { 2, 2, "http://localhost:5002/swagger/oauth2-redirect.html" });

            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[] { 4, 2, "Manufacturer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:5002");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5002/");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "http://localhost:5002/");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClientUri",
                value: "http://localhost:5002");
        }
    }
}
