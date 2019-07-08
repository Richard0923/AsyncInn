using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoomManager
    {
        //create 
        Task CreateRoom(Room room);

        //getbyid
        Task<Room> GetRoomByID(int id);

        //getall
        Task<List<Room>> GetRoomsList();

        //update
        Task UpdateRooms(Room room);

        //delete
        Task DeleteRoom(int id);

        //create a list to grab the amenities 
        Task<List<RoomAmenities>> GetAmenitiesRoom(int roomID);
    }
}
