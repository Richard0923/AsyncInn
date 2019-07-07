using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class HotelTest
    {
        [Fact]
        public void HotelObjectTest()
        {
            //arrange 
            Hotel testHotel = new Hotel();
            var id = 20;
            var name = "TEST HOTEL";
            var city = "seattle";
            var state = "WA";
            //act
            testHotel.ID = id;
            testHotel.Name = name;
            testHotel.City = city;
            testHotel.State = state;
            //assert
            Assert.Equal(id, testHotel.ID);
            Assert.Equal(name, testHotel.Name);
            Assert.Equal(city, testHotel.City);
            Assert.Equal(state, testHotel.State);

        }

    }
}
