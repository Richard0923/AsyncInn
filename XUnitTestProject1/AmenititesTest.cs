using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
   public class AmenititesTest
    {
        [Fact]
        public void AmenitiesObjectTest()
        {
            Amenities testamenity = new Amenities();
            var id = 40;
            var name = "test";

            testamenity.ID = id;
            testamenity.Name = name;

            Assert.Equal(id, testamenity.ID);
            Assert.Equal(name, testamenity.Name);

        }
    }
}
