using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }

        public int RoomID { get; set; }

        public Room Room { get; set; }

        //sets the Navagation to the other database and sets it as a generic collection
        public ICollection<Amenities> Amenitites { get; set; }

    }
}
