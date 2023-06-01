using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Data.Migrations
{
    public partial class v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "barberkü.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "cheddar.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "citirtop.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "barberkü.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "karisiktabak.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "kasardolgu.webp");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "ketcap.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "mayonez.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "ranchsos.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "sarimsaklimayonez.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 11,
                column: "Photo",
                value: "sinitzel.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "sweetchillisos.jpg");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "f2.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "f8.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "f7.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "f3.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "f1.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "f6.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "f9.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "f4.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "f5.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "/Assest/images/barberkü.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "/Assest/images/cheddar.jpg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "/Assest/images/citirtop.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "/Assest/images/barberkü.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "/Assest/images/karisiktabak.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "/Assest/images/kasardolgu.webp");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "/Assest/images/ketcap.jpeg");

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
                keyValue: 11,
                column: "Photo",
                value: "/Assest/images/sinitzel.jpeg");

            migrationBuilder.UpdateData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 12,
                column: "Photo",
                value: "/Assest/images/sweetchillisos.jpg");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "/Assest/images/f2.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "/Assest/images/f8.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "/Assest/images/f7.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "/Assest/images/f3.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "Photo",
                value: "/Assest/images/f1.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "/Assest/images/f6.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "/Assest/images/f9.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "Photo",
                value: "/Assest/images/f4.png");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "/Assest/images/f5.png");
        }
    }
}
