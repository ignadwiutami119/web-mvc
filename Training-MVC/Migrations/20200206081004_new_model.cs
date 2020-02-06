using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class new_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "produk",
                table: "carts");

            migrationBuilder.AddColumn<int>(
                name: "CartsID",
                table: "items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_items_CartsID",
                table: "items",
                column: "CartsID");

            migrationBuilder.AddForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items",
                column: "CartsID",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_CartsID",
                table: "items");

            migrationBuilder.DropColumn(
                name: "CartsID",
                table: "items");

            migrationBuilder.AddColumn<string>(
                name: "produk",
                table: "carts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
