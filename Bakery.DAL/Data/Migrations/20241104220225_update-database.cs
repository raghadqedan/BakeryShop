using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
