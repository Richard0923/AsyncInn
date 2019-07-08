using AsyncInn.Models;
using AsyncInn.Models.Interfaces;
using System;
using Xunit;
using Moq;
using AsyncInn.Models.Services;
using System.Threading.Tasks;
using AsyncInn.Controllers;

namespace XUnitTestProject1
{
    public class RoomTest
    {

        //test the room class
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

        [Fact]
        public async Task RoomControllerCreateTestAsync()
        {
            //need to find a way to test the controller 
            //arrange 
            //make test room
            var id = 22;
            var name = "testy room";
            Room roomT = new Room { ID = id, Name = name };
            var mock = new Mock<IRoomManager>();
            //setup the call for the mock 
            mock.Setup(r => r.GetRoomByID(id)).ReturnsAsync(roomT);
            var roomController = new RoomsController(mock.Object);
            var placeholder = roomController;//test is not complete still need to figure out what im testing for 
            //act

            //assert
        }
    }
}
