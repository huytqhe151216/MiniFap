using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFap.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "FullName1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName1",
                table: "Users",
                newName: "FullName");
        }
    }
}
