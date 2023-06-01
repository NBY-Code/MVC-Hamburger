using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Data.Migrations
{
    public partial class MigV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "ExtraMaterials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ExtraMaterials",
                columns: new[] { "Id", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, "Barbekü", "/Assest/images/barberkü.jpeg", 1.00m },
                    { 2, "Cheddar", "/Assest/images/cheddar.jpeg", 1.50m },
                    { 3, "Crispy Ball", "/Assest/images/citirtop.jpeg", 1.50m },
                    { 4, "Barbeque Sauce", "/Assest/images/barberkü.jpeg", 1.00m },
                    { 5, "Mixed Special", "/Assest/images/karisiktabak.jpeg", 11.00m },
                    { 6, "Cheddar Filling", "/Assest/images/kasardolgu.webp", 5.00m },
                    { 7, "Ketchup", "/Assest/images/ketcap.jpeg", 1.00m },
                    { 8, "Mayonnaise", "/Assest/images/mayonez.jpeg", 1.00m },
                    { 9, "Ranch Sauce", "/Assest/images/ranchsos.jpeg", 1.00m },
                    { 10, "Garlic Mayonnaise", "/Assest/images/sarimsaklimayonez.jpeg", 1.00m },
                    { 11, "Schnitzel", "/Assest/images/sinitzel.jpeg", 8.75m },
                    { 12, "Sweet Chilli Sauce", "/Assest/images/sweetchillisos.jpeg", 1.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "ExtraMaterials");
        }
    }
}
