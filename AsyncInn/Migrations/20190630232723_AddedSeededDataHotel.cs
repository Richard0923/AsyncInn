using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class AddedSeededDataHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelID", "City", "Name", "Phone", "State" },
                values: new object[,]
                {
                    { 1, "Seattle", "The Sound", "1234567892", "WA" },
                    { 2, "Miami", "South Beach", "7863589847", "FL" },
                    { 3, "Arecibo ", "La Isla", "7874567975", "PR" },
                    { 4, "New York City ", "Empire", "2829877237", "NY" },
                    { 5, "Los Angeles", "LA", "2678365839", "CA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 5);
        }
    }
}
