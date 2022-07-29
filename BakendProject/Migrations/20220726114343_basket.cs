using Microsoft.EntityFrameworkCore.Migrations;

namespace BakendProject.Migrations
{
    public partial class basket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "BasketItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "BasketItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Sum",
                table: "BasketItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Sum",
                table: "BasketItems");
        }
    }
}
