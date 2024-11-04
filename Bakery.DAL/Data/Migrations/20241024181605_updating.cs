using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fd23575-48ba-4c53-b193-2f5db33de4fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f814f857-93e6-46e7-b17a-e5b58a50980d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5704d29b-d4ff-443f-88a1-3760d6768440", "9acd357b-8ad2-444e-8143-a07cd2845861" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5704d29b-d4ff-443f-88a1-3760d6768440");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9acd357b-8ad2-444e-8143-a07cd2845861");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fd23575-48ba-4c53-b193-2f5db33de4fd", "2e2795fb-76a0-4196-b401-24b1bbc22bd7", "Admin", "ADMIN" },
                    { "5704d29b-d4ff-443f-88a1-3760d6768440", "d7d9e239-a293-4b59-9e15-a82b19406b98", "SuperAdmin", "SUPERADMIN" },
                    { "f814f857-93e6-46e7-b17a-e5b58a50980d", "0f4443a1-7a3f-43c2-8421-523af2965a87", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9acd357b-8ad2-444e-8143-a07cd2845861", 0, null, null, "4a54482b-2c84-4411-bf60-9fab5be061e5", null, "superAdmin@comp.com", false, null, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEF8zpvDqp2VJ+G9oRKkTkt8KjZpKP77uoXMtQemUK+ACD9PfaR3vqUORUiCE16D/uQ==", null, false, "b8f3844b-877b-4759-897e-1a55a427b31d", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5704d29b-d4ff-443f-88a1-3760d6768440", "9acd357b-8ad2-444e-8143-a07cd2845861" });
        }
    }
}
