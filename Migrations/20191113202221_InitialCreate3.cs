using Microsoft.EntityFrameworkCore.Migrations;

namespace WidgetCorporation.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_CustomerID",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
