using AsyncInn.Models;
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
            modelBuilder.Entity<RoomAmenities>().HasKey(RoomAmenities =>
            new { RoomAmenities.RoomID,  RoomAmenities.AmenitiesID });

            modelBuilder.Entity<HotelRoom>().HasKey(hotelRoom =>
            new { hotelRoom.RoomID, hotelRoom.HotelID });
        }

        //sets up the db so that contextdb can read it 
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomAmenities> RoomAmenities { get; set; }

        public DbSet<Amenities> Amenities { get; set; }

    }
}
