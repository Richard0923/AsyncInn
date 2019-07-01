using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class AddedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HotelRooms_HotelRoomRoomID_HotelRoomHotelID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelRoomRoomID_HotelRoomHotelID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelRoomHotelID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelRoomRoomID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Rooms",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "HotelID",
                table: "Hotels",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Rooms",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Hotels",
                newName: "HotelID");

            migrationBuilder.AddColumn<int>(
                name: "HotelRoomHotelID",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelRoomRoomID",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelRoomRoomID_HotelRoomHotelID",
                table: "Rooms",
                columns: new[] { "HotelRoomRoomID", "HotelRoomHotelID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_HotelRooms_HotelRoomRoomID_HotelRoomHotelID",
                table: "Rooms",
                columns: new[] { "HotelRoomRoomID", "HotelRoomHotelID" },
                principalTable: "HotelRooms",
                principalColumns: new[] { "RoomID", "HotelID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
