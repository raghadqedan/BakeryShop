using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class updateproducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15654d89-21ad-4cb1-b712-5e6bae63ba35", "85dec1bb-0dec-4fbd-822c-8d535906ad2e", "SuperAdmin", "SUPERADMIN" },
                    { "193c555c-adc6-44d2-ba02-38af456921a3", "2dc5b1b0-b15f-4b37-83c9-3cd54d467d20", "Admin", "ADMIN" },
                    { "c8cd8ce1-c958-4dca-a1c1-ca5b39c4d8fc", "4427f0cb-68f1-47c3-9257-692c2aa46f6e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e860f65-fcd1-43c4-9c37-78cce232406d", 0, null, null, "e95964c4-7900-46c3-8ca5-723966b2de0b", null, "superAdmin@comp.com", false, "superAdmin", "superAdmin", false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAEAACcQAAAAEACru/hyKtdglRc1bWTLJbAwuCatA+4BFHSZJaE8vdSGH9ENb8PVnSg9myEXw58INg==", null, false, "c4b85b07-a5b7-4fa0-b174-29f50729830f", false, "superAdmin@comp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15654d89-21ad-4cb1-b712-5e6bae63ba35", "6e860f65-fcd1-43c4-9c37-78cce232406d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "193c555c-adc6-44d2-ba02-38af456921a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8cd8ce1-c958-4dca-a1c1-ca5b39c4d8fc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15654d89-21ad-4cb1-b712-5e6bae63ba35", "6e860f65-fcd1-43c4-9c37-78cce232406d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15654d89-21ad-4cb1-b712-5e6bae63ba35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e860f65-fcd1-43c4-9c37-78cce232406d");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Products");

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
    }
}
