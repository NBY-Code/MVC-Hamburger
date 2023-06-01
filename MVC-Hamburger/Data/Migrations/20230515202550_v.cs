using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Data.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, "Cheeseburger", "/Assest/images/f2.png", 9.99m },
                    { 2, "Chicken burger", "/Assest/images/f8.png", 11.99m },
                    { 3, "Chicken Cheeseburger", "/Assest/images/f7.png", 13.99m },
                    { 4, "Pepperoni Pizza", "/Assest/images/f3.png", 14.99m },
                    { 5, "Margherita Pizza", "/Assest/images/f1.png", 12.99m },
                    { 6, "Meat Lovers Pizza", "/Assest/images/f6.png", 16.99m },
                    { 7, "Spaghetti Carbonara", "/Assest/images/f9.png", 10.99m },
                    { 8, "Special Pasta", "/Assest/images/f4.png", 11.99m },
                    { 9, "Garlic Fries", "/Assest/images/f5.png", 4.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
