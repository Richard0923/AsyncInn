using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    HotelID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    PetFriendly = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => new { x.RoomID, x.HotelID });
                    table.ForeignKey(
                        name: "FK_HotelRooms_Hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Layout = table.Column<int>(nullable: false),
                    HotelRoomRoomID = table.Column<int>(nullable: true),
                    HotelRoomHotelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_HotelRooms_HotelRoomRoomID_HotelRoomHotelID",
                        columns: x => new { x.HotelRoomRoomID, x.HotelRoomHotelID },
                        principalTable: "HotelRooms",
                        principalColumns: new[] { "RoomID", "HotelID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomAmenities",
                columns: table => new
                {
                    AmenitiesID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenities", x => new { x.RoomID, x.AmenitiesID });
                    table.ForeignKey(
                        name: "FK_RoomAmenities_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenitiesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RoomAmenitiesRoomID = table.Column<int>(nullable: true),
                    RoomAmenitiesAmenitiesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenitiesID);
                    table.ForeignKey(
                        name: "FK_Amenities_RoomAmenities_RoomAmenitiesRoomID_RoomAmenitiesAmenitiesID",
                        columns: x => new { x.RoomAmenitiesRoomID, x.RoomAmenitiesAmenitiesID },
                        principalTable: "RoomAmenities",
                        principalColumns: new[] { "RoomID", "AmenitiesID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_RoomAmenitiesRoomID_RoomAmenitiesAmenitiesID",
                table: "Amenities",
                columns: new[] { "RoomAmenitiesRoomID", "RoomAmenitiesAmenitiesID" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_HotelID",
                table: "HotelRooms",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelRoomRoomID_HotelRoomHotelID",
                table: "Rooms",
                columns: new[] { "HotelRoomRoomID", "HotelRoomHotelID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "RoomAmenities");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
