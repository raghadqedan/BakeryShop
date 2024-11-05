using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class updateusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219102b7-3b69-4585-9ead-2e5de446d6eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceeaaf2f-9ac1-4d33-8823-29ff9990cb53");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a5b6b24-8346-4e5e-a766-b9d7046fbce0", "956696f4-5472-454e-a3a2-42d37beff7cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a5b6b24-8346-4e5e-a766-b9d7046fbce0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "956696f4-5472-454e-a3a2-42d37beff7cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1812ad0c-9b47-458b-be4a-7a6241cc8127", "5e1d3419-ce4e-4f03-978a-4d30dc8b31b0", "User", "USER" },
                    { "3082cd33-1ce7-4042-9268-e5d946c510c6", "4836d912-db5f-4cc9-ab16-58aeccc2cc81", "SuperAdmin", "SUPERADMIN" },
                    { "f936cf4d-9924-4a47-900e-e8cb858dd2f9", "cd3dc512-cf6b-4b5d-a0ef-4041a693cb24", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cdda0585-1c2e-4726-92ee-db2f06eb9a97", 0, null, null, "84826029-7b9f-4115-9fc0-dc916faf9e71", null, "superAdmin@comp.com", false, "superAdmin", "superAdmin", false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEApcmyDf2/fBpidzb5uoR2SZPn2KiV0+1+YYakxiLoyd6okua6n+8bnL89EUBzWsVQ==", null, false, "12511204-1674-435e-a204-7fe9a4b5d6b9", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3082cd33-1ce7-4042-9268-e5d946c510c6", "cdda0585-1c2e-4726-92ee-db2f06eb9a97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1812ad0c-9b47-458b-be4a-7a6241cc8127");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f936cf4d-9924-4a47-900e-e8cb858dd2f9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3082cd33-1ce7-4042-9268-e5d946c510c6", "cdda0585-1c2e-4726-92ee-db2f06eb9a97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3082cd33-1ce7-4042-9268-e5d946c510c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdda0585-1c2e-4726-92ee-db2f06eb9a97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a5b6b24-8346-4e5e-a766-b9d7046fbce0", "f196cde0-4e23-4180-bea3-0798fdc63abb", "SuperAdmin", "SUPERADMIN" },
                    { "219102b7-3b69-4585-9ead-2e5de446d6eb", "b2adb69c-efcb-42c4-8449-382490242865", "Admin", "ADMIN" },
                    { "ceeaaf2f-9ac1-4d33-8823-29ff9990cb53", "2ef237a6-5ab3-4926-9fec-8f8f6124bd99", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "956696f4-5472-454e-a3a2-42d37beff7cb", 0, null, null, "5d06afcb-1c65-44e1-ab3e-224291c0533f", null, "superAdmin@comp.com", false, "superAdmin", "superAdmin", false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEMdAZ/pyHRLxAYQCYysrz3Qibomb5QVLPMmst3d5OOVoU8K9urn7iXcmC1I9TalQjQ==", null, false, "69857a17-510c-44f0-b18d-ee2390986427", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a5b6b24-8346-4e5e-a766-b9d7046fbce0", "956696f4-5472-454e-a3a2-42d37beff7cb" });
        }
    }
}
