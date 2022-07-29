using Microsoft.EntityFrameworkCore.Migrations;

namespace BakendProject.Migrations
{
    public partial class authorNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorDesc",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorImageUrl",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorDesc",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "AuthorImageUrl",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Bios");
        }
    }
}
