using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bb45d9d-0668-4f35-ba5e-f90580f3b23b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0cf90af-5feb-474e-8e2e-11e85fa54c25");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19cb76fe-95a1-4aff-b72d-9e4ad0ca0573", "8b09c210-e10d-4bb5-af5e-bf10507bde38" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19cb76fe-95a1-4aff-b72d-9e4ad0ca0573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b09c210-e10d-4bb5-af5e-bf10507bde38");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "455d586e-dd21-447c-9e89-58fedcc0fcbe", "409c1cf2-d7cd-4696-a74a-b0357cc3c9ec", "User", "USER" },
                    { "496522e1-ab1d-47da-8269-dc9de77b9595", "a4fa6752-9f6c-4173-b6c1-58443f6f5c78", "Admin", "ADMIN" },
                    { "76ab100a-cce4-469b-b9a8-ba11c29fbdde", "1a30fc3d-64ab-41e9-a3db-b22ae1acd327", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "de2c3626-9875-4191-a008-2c44d1d86256", 0, null, null, "6cecce55-045e-4dd8-a3b3-7ab1284645b6", null, "superAdmin@comp.com", false, null, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEA10oHxTUuby2VkVB6Iv7DT40mNHJQZjq821XobmfGy892lD0OCSLtUkyYQuxE7ugQ==", null, false, "35f1b644-f998-4af1-ba1d-6959de1a9b27", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76ab100a-cce4-469b-b9a8-ba11c29fbdde", "de2c3626-9875-4191-a008-2c44d1d86256" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "455d586e-dd21-447c-9e89-58fedcc0fcbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "496522e1-ab1d-47da-8269-dc9de77b9595");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76ab100a-cce4-469b-b9a8-ba11c29fbdde", "de2c3626-9875-4191-a008-2c44d1d86256" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76ab100a-cce4-469b-b9a8-ba11c29fbdde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de2c3626-9875-4191-a008-2c44d1d86256");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19cb76fe-95a1-4aff-b72d-9e4ad0ca0573", "f82d4dea-994b-420e-9689-e78d8bbe137d", "SuperAdmin", "SUPERADMIN" },
                    { "4bb45d9d-0668-4f35-ba5e-f90580f3b23b", "6111ae22-3dff-47d6-bf8c-eb2d40261164", "Admin", "ADMIN" },
                    { "b0cf90af-5feb-474e-8e2e-11e85fa54c25", "ce2da98e-e769-42e3-95ab-5875e4ac2143", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b09c210-e10d-4bb5-af5e-bf10507bde38", 0, null, null, "0bc30185-982c-45d3-9b15-89907e090fa3", null, "superAdmin@comp.com", false, null, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEPRXfmnVXC6mzsJHu41ZgCc76UIq9y8UYLg4UGj536QoZzcSqKccyoQHtap06Y0KNQ==", null, false, "5483e116-5c24-4eff-8d8a-b53a184119c1", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "19cb76fe-95a1-4aff-b72d-9e4ad0ca0573", "8b09c210-e10d-4bb5-af5e-bf10507bde38" });
        }
    }
}
