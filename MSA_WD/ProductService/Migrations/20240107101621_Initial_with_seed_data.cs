using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    public partial class Initial_with_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "It includes all electronic equipments TV, Freeze, Washing Machines etc.", "Electronics" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 1, "MI 80 Cm (32 Inches) A Series Hd Ready Smart Google LED Tv L32M8-5Ain (Black)", "https://m.media-amazon.com/images/I/713A5VksK6L._SX679_.jpg", "MI LED", 13000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 1, "Samtonic 80 cm (32 Inches) Full HD Smart Android LED TV | Powerful Audio Box Speakers | HDMI & USB Ports | Voice Remote (Black, 2023 Model)", "https://m.media-amazon.com/images/I/411dUvxz1+L._SX679_.jpg", "Samtonic LED", 10000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
