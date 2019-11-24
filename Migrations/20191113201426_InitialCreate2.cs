using Microsoft.EntityFrameworkCore.Migrations;

namespace WidgetCorporation.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_CustomerID1",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID1",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "Cart");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Cart",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Customer_CustomerID",
                table: "Cart",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_CustomerID",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CustomerID1",
                table: "Cart",
                type: "int",
                nullable: true);

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
        }
    }
}
