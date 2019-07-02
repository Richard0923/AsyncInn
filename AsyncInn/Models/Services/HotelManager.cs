using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelManager : IHotelManager
    {
        
        private readonly AsyncInnDbContext _context;

        //injects the database so we can use it 
        public HotelManager(AsyncInnDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new Hotel and saves it to the Database 
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns>Returns a Task of an async method</returns>
        public async Task CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes the Hotel by ID 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an async task</returns>
        public async Task DeleteHotel(int id)
        {
            Hotel hotel = await GetHotelByID(id);
            _context.Hotels.Remove(hotel);
        }

        /// <summary>
        /// Finds a Hotel by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an async task of a Hotel</returns>
        public async Task<Hotel> GetHotelByID(int id) => await _context.Hotels.FindAsync(id);
        

        public List<Hotel> GetHotelList()
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
