using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.DAL.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUser_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_Order_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Product_Product_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_AspNetUsers_ApplicationUser_Id",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Category_Id",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Paymet");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrdersDetails");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Category_Id",
                table: "Products",
                newName: "IX_Products_Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_ApplicationUser_Id",
                table: "Paymet",
                newName: "IX_Paymet_ApplicationUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Product_Id",
                table: "OrdersDetails",
                newName: "IX_OrdersDetails_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Order_Id",
                table: "OrdersDetails",
                newName: "IX_OrdersDetails_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ApplicationUser_Id",
                table: "Orders",
                newName: "IX_Orders_ApplicationUser_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paymet",
                table: "Paymet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersDetails",
                table: "OrdersDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cart_Id = table.Column<int>(type: "int", nullable: false),
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUser_Id",
                table: "Orders",
                column: "ApplicationUser_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Orders_Order_Id",
                table: "OrdersDetails",
                column: "Order_Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Products_Product_Id",
                table: "OrdersDetails",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paymet_AspNetUsers_ApplicationUser_Id",
                table: "Paymet",
                column: "ApplicationUser_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_Id",
                table: "Products",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUser_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Orders_Order_Id",
                table: "OrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Products_Product_Id",
                table: "OrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Paymet_AspNetUsers_ApplicationUser_Id",
                table: "Paymet");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_Id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paymet",
                table: "Paymet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersDetails",
                table: "OrdersDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

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

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Paymet",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "OrdersDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Category_Id",
                table: "Product",
                newName: "IX_Product_Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Paymet_ApplicationUser_Id",
                table: "Payment",
                newName: "IX_Payment_ApplicationUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetails_Product_Id",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetails_Order_Id",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ApplicationUser_Id",
                table: "Order",
                newName: "IX_Order_ApplicationUser_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUser_Id",
                table: "Order",
                column: "ApplicationUser_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_Order_Id",
                table: "OrderDetails",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Product_Product_Id",
                table: "OrderDetails",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_AspNetUsers_ApplicationUser_Id",
                table: "Payment",
                column: "ApplicationUser_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Category_Id",
                table: "Product",
                column: "Category_Id",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
