using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomManager : IRoomManager
    {
        private readonly AsyncInnDbContext _context;

        public RoomManager(AsyncInnDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a room to the database and saves the changes using async
        /// </summary>
        /// <param name="room"></param>
        /// <returns>Returns a async task</returns>
        public async Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the room equal to the id passed in 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an async task</returns>
        public async Task DeleteRoom(int id)
        {
            Room room = await GetRoomByID(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

        }

        /// <summary>
        /// Gets the room for the id passed 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns an async task of an room</returns>
        public async Task<Room> GetRoomByID(int id) => await _context.Rooms.FindAsync(id);
        
        /// <summary>
        /// Creates a list of all the rooms saved to the database
        /// </summary>
        /// <returns>Returns a List of rooms</returns>
        public async Task<List<Room>> GetRoomsList()
        {
            return await _context.Rooms.ToListAsync();
        }

        /// <summary>
        /// Updates a room and saves it to the database 
        /// </summary>
        /// <param name="room"></param>
        /// <returns>Returns am async Task </returns>
        public async Task UpdateRooms(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
