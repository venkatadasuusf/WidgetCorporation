using Microsoft.EntityFrameworkCore.Migrations;

namespace WidgetCorporation.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Cart",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID1",
                table: "Cart",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Login_CustomerID",
                table: "Login",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartID",
                table: "CartDetails",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductID",
                table: "CartDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerID1",
                table: "Cart",
                column: "CustomerID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Customer_CustomerID1",
                table: "Cart",
                column: "CustomerID1",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Cart_CartID",
                table: "CartDetails",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Product_ProductID",
                table: "CartDetails",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Customer_CustomerID",
                table: "Login",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_CustomerID1",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Cart_CartID",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Product_ProductID",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_Customer_CustomerID",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Login_CustomerID",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_CartID",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_ProductID",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID1",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "Cart");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Cart",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
