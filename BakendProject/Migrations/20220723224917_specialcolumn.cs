using Microsoft.EntityFrameworkCore.Migrations;

namespace BakendProject.Migrations
{
    public partial class specialcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SpecialProduct",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialProduct",
                table: "Products");
        }
    }
}
