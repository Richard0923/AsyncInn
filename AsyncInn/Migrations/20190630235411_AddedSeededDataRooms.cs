using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class AddedSeededDataRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "HotelRoomHotelID", "HotelRoomRoomID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, null, null, 0, "Bathroom Not Included" },
                    { 2, null, null, 1, "One Bed No Windows" },
                    { 3, null, null, 2, "Two Bed and 3 Squatters" },
                    { 4, null, null, 0, "Almost a Room" },
                    { 5, null, null, 1, "One bedroom rats included" },
                    { 6, null, null, 2, "A Suite but without the sweetness" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 6);
        }
    }
}
