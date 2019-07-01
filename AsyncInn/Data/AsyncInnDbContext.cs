﻿using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {

        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options) { }

        //setting up the use of composite keys 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //binding composite keys using Fluent API
            modelBuilder.Entity<RoomAmenities>().HasKey(ra =>
            new { ra.RoomID,  ra.AmenitiesID });

            modelBuilder.Entity<HotelRoom>().HasKey(hr =>
            new { hr.RoomID, hr.HotelID });

            //seed the data 
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "The Sound",
                    City = "Seattle",
                    State = "WA",
                    Phone = "1234567892"
                },
                new Hotel
                {
                    ID = 2,
                    Name = "South Beach",
                    City = "Miami",
                    State = "FL",
                    Phone = "7863589847"
                },
                new Hotel
                {
                    ID = 3,
                    Name = "La Isla",
                    City = "Arecibo ",
                    State = "PR",
                    Phone = "7874567975"
                },
                new Hotel
                {
                    ID = 4,
                    Name = "Empire",
                    City = "New York City ",
                    State = "NY",
                    Phone = "2829877237"
                },
                new Hotel
                {
                    ID = 5,
                    Name = "LA",
                    City = "Los Angeles",
                    State = "CA",
                    Phone = "2678365839"
                }
                );

            //seed data for next DB
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Bathroom Not Included",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 2,
                    Name = "One Bed No Windows",
                    Layout = Layout.OneBedRoom,
                },
                new Room
                {
                    ID = 3,
                    Name = "Two Bed and 3 Squatters",
                    Layout = Layout.TwoBedRoom,
                },
                new Room
                {
                    ID = 4,
                    Name = "Almost a Room",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 5,
                    Name = "One bedroom rats included",
                    Layout = Layout.OneBedRoom,
                },
                new Room
                {
                    ID = 6,
                    Name = "A Suite but without the sweetness",
                    Layout = Layout.TwoBedRoom,
                }
                );
            //seed data for Amenitites
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Bathroom"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Hot Tub"
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Disco Ball"
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Windows"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Rats"
                }
                );
        }

        //sets up the db so that contextdb can read it 
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomAmenities> RoomAmenities { get; set; }

        public DbSet<Amenities> Amenities { get; set; }

    }
}
