using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        //create 
        Task CreateAmenity(Amenities amenity);

        //delete
        Task DeleteAmenity(int id);

        //grabbyid
        Task<Amenities> GetAmenityByID(int id);

        //graballList
        Task<List<Amenities>> GetAmenities();
        
    }
}
