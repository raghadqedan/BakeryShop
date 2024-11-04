using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdf9c53a-a08a-485d-bb08-863cef489406");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a4ff77-95f7-4b7c-b1ec-0cdf3f3cc853");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ab82ac1-d3b8-40ae-8462-e2b5f3633f61", "9a21ad26-2fbb-447f-bcd1-6612ad06f417" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ab82ac1-d3b8-40ae-8462-e2b5f3633f61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a21ad26-2fbb-447f-bcd1-6612ad06f417");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0540447f-04c9-43b7-b0cf-74f30e8f7547", "68f2e7f7-aed1-444a-b725-aaacb392a09e", "Admin", "ADMIN" },
                    { "278dce8f-fa70-474d-af71-506afd815327", "40d5c5d5-3c6e-4a8e-b180-d6cf626cf968", "SuperAdmin", "SUPERADMIN" },
                    { "db898c93-c29c-4232-9bf3-fd83241ed199", "2aecd2ad-90d5-4879-af09-b3b4265dc5e8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9bab3cf6-cf16-4cf3-99c2-39eacafe6094", 0, null, null, "9efe791c-ecf8-4bc1-b666-0952dfe8ecab", null, "superAdmin@comp.com", false, null, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAELVIjJPcXtoQXyp+PpeKd692mWYZdN7Q9w/n5J2k7kz6JX9hkbAKMcK6RCU/G8hrag==", null, false, "1406b664-b1ee-4681-b7e5-2ea2a3216a96", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "278dce8f-fa70-474d-af71-506afd815327", "9bab3cf6-cf16-4cf3-99c2-39eacafe6094" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0540447f-04c9-43b7-b0cf-74f30e8f7547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db898c93-c29c-4232-9bf3-fd83241ed199");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "278dce8f-fa70-474d-af71-506afd815327", "9bab3cf6-cf16-4cf3-99c2-39eacafe6094" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "278dce8f-fa70-474d-af71-506afd815327");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bab3cf6-cf16-4cf3-99c2-39eacafe6094");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ab82ac1-d3b8-40ae-8462-e2b5f3633f61", "1a2bf60f-a9f3-41de-aba3-781594be8d88", "SuperAdmin", "SUPERADMIN" },
                    { "bdf9c53a-a08a-485d-bb08-863cef489406", "2ee4f6bf-30fe-4c11-9cba-9b371c129c74", "Admin", "ADMIN" },
                    { "d9a4ff77-95f7-4b7c-b1ec-0cdf3f3cc853", "51ec3602-a571-4111-a972-65af30c62a53", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a21ad26-2fbb-447f-bcd1-6612ad06f417", 0, null, null, "17e6b345-2113-4717-8517-501bc9f7bc9d", null, "superAdmin@comp.com", false, null, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEPVMrawBJk/XXqGZZ8blhUPGCXN7wlgOh0RU5sQ8/zx0KbL7su7Nyw2o0GtJjeFymA==", null, false, "88bdcf69-674c-4168-8e66-76d461720026", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6ab82ac1-d3b8-40ae-8462-e2b5f3633f61", "9a21ad26-2fbb-447f-bcd1-6612ad06f417" });
        }
    }
}
