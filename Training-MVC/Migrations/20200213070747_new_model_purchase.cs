using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class new_model_purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items");

            migrationBuilder.AlterColumn<int>(
                name: "CartsID",
                table: "items",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items",
                column: "CartsID",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items");

            migrationBuilder.AlterColumn<int>(
                name: "CartsID",
                table: "items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_items_carts_CartsID",
                table: "items",
                column: "CartsID",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
