using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio01.Migrations
{
    public partial class updateTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tag",
                table: "Tags",
                newName: "TagName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagName",
                table: "Tags",
                newName: "tag");
        }
    }
}
