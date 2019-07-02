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
        List<Hotel> GetHotelList();

        //update 
        void UpdateHotel(Hotel hotel);

        //delete
        void DeleteHotel(int id);
    }
}
