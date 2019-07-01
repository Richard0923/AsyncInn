﻿// <auto-generated />
using System;
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20190630232723_AddedSeededDataHotel")]
    partial class AddedSeededDataHotel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("AmenitiesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("RoomAmenitiesAmenitiesID");

                    b.Property<int?>("RoomAmenitiesRoomID");

                    b.HasKey("AmenitiesID");

                    b.HasIndex("RoomAmenitiesRoomID", "RoomAmenitiesAmenitiesID");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.HasKey("HotelID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelID = 1,
                            City = "Seattle",
                            Name = "The Sound",
                            Phone = "1234567892",
                            State = "WA"
                        },
                        new
                        {
                            HotelID = 2,
                            City = "Miami",
                            Name = "South Beach",
                            Phone = "7863589847",
                            State = "FL"
                        },
                        new
                        {
                            HotelID = 3,
                            City = "Arecibo ",
                            Name = "La Isla",
                            Phone = "7874567975",
                            State = "PR"
                        },
                        new
                        {
                            HotelID = 4,
                            City = "New York City ",
                            Name = "Empire",
                            Phone = "2829877237",
                            State = "NY"
                        },
                        new
                        {
                            HotelID = 5,
                            City = "Los Angeles",
                            Name = "LA",
                            Phone = "2678365839",
                            State = "CA"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("RoomID");

                    b.Property<int>("HotelID");

                    b.Property<bool>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomNumber");

                    b.HasKey("RoomID", "HotelID");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelRoomHotelID");

                    b.Property<int?>("HotelRoomRoomID");

                    b.Property<int>("Layout");

                    b.Property<string>("Name");

                    b.HasKey("RoomID");

                    b.HasIndex("HotelRoomRoomID", "HotelRoomHotelID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("RoomID");

                    b.Property<int>("AmenitiesID");

                    b.HasKey("RoomID", "AmenitiesID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.HasOne("AsyncInn.Models.RoomAmenities", "RoomAmenities")
                        .WithMany("Amenitites")
                        .HasForeignKey("RoomAmenitiesRoomID", "RoomAmenitiesAmenitiesID");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.HasOne("AsyncInn.Models.HotelRoom", "HotelRoom")
                        .WithMany("Room")
                        .HasForeignKey("HotelRoomRoomID", "HotelRoomHotelID");
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
