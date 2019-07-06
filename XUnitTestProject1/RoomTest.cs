using AsyncInn.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class RoomTest
    {
        [Fact]
        public void RoomObjectTest()
        {
            //arrange 
            Room roomTest = new Room();
            roomTest.ID = 10;
            roomTest.Name = "test room";
            roomTest.Layout = Layout.Studio;

            //act 
            int roomid = roomTest.ID;
            string roomName = roomTest.Name;
            Layout roomlayout = roomTest.Layout;

            //Assert 
            Assert.Equal(roomid, roomTest.ID);
            Assert.Equal(roomName, roomTest.Name);
            Assert.Equal(roomlayout, roomTest.Layout);
        }
    }
}
