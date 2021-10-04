using Microsoft.EntityFrameworkCore.Migrations;

namespace MenuApp.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_Menu",
                table: "menuclasses",
                newName: "IdMenu");

            migrationBuilder.RenameColumn(
                name: "ID_Application",
                table: "menuclasses",
                newName: "IdApplication");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdMenu",
                table: "menuclasses",
                newName: "ID_Menu");

            migrationBuilder.RenameColumn(
                name: "IdApplication",
                table: "menuclasses",
                newName: "ID_Application");
        }
    }
}
