using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraryies.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
