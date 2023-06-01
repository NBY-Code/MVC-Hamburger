using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Data.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "/Assest/images/cheddar.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "/Assest/images/mayonez.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "/Assest/images/ranchsos.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "/Assest/images/sarimsaklimayonez.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "/Assest/images/sweetchillisos.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "/Assest/images/cheddar.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "/Assest/images/mayonez.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "/Assest/images/ranchsos.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "/Assest/images/sarimsaklimayonez.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "/Assest/images/sweetchillisos.jpeg");
        }
    }
}
