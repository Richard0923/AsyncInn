using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class AddedSeededDataAmen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AmenitiesID",
                table: "Amenities",
                newName: "ID");

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name", "RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID" },
                values: new object[,]
                {
                    { 1, "Bathroom", null, null },
                    { 2, "Hot Tub", null, null },
                    { 3, "Disco Ball", null, null },
                    { 4, "Windows", null, null },
                    { 5, "Rats", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Amenities",
                newName: "AmenitiesID");
        }
    }
}
