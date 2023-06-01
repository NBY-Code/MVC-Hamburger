using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Menus",
                newName: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "OrdersMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "OrdersMenus");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Menus",
                newName: "Image");
        }
    }
}
