using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Layout Layout { get; set; }

        public HotelRoom HotelRoom { get; set; }

        public ICollection<RoomAmenities> RoomAmenities { get; set; }

    }

    public enum Layout
    {
        Studio = 0,
        OneBedRoom = 1,
        TwoBedRoom = 2
    }
}
