using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class modelbarulagi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "purchases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "purchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "purchases");

            migrationBuilder.DropColumn(
                name: "address",
                table: "purchases");
        }
    }
}
