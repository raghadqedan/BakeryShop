using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class imagesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "ImageName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Products",
                newName: "Image");

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
    }
}
