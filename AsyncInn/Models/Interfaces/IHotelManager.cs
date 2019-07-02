using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    interface IHotelManager
    {
        //create 
        Task CreateHotel(Hotel hotel);

        //getbyid
        Task<Hotel> GetHotelByID(int id);

        //getall
        Task<List<Hotel>> GetHotelList();

        //update 
        Task UpdateHotel(Hotel hotel);

        //delete
        Task DeleteHotel(int id);
    }
}
