using Microsoft.EntityFrameworkCore.Migrations;

namespace sluCHAYno.Migrations
{
    public partial class rename_ImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "MenuItems");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "MenuItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "MenuItems");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
