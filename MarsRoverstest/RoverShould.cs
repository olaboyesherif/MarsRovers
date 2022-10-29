using MarsRover.Data;
using MarsRover.Interface;

namespace MarsRoverstest
{
    [TestClass]
    public class RoverShould
    {
        
        private readonly IRoverService _roverService;
        public RoverShould(IRoverService roverService)
        {
            _roverService = roverService;
        }
        [TestMethod]
        public void SpinLeft()
        {
            //arrange
            RoverDTO rover = new RoverDTO();
            rover.x = 1;
            rover.y = 2;
            var result = rover.direction = "N";
            //act
            result = _roverService.SpinLeft(rover).GetAwaiter().GetResult();
            //assert
            //  Assert.True(rover.direction == "W");
            Assert.AreEqual("W", result);
         

        }
        [TestMethod]

        public void SpinRight()
        {
            //arrange
            RoverDTO rover = new RoverDTO();
            rover.x = 1;
            rover.y = 2;
            var result = rover.direction = "N";
            //act
            result = _roverService.SpinRight(rover).GetAwaiter().GetResult();
            //assert
           
             Assert.AreEqual("W", rover.direction);
        }
        [TestMethod]

        public void StepForward()
        {
            //arrange
            RoverDTO rover = new RoverDTO();
            rover.x = 1;
            rover.y = 2;
            var result = rover.direction = "N";
            //act
            result = _roverService.SpinRight(rover).GetAwaiter().GetResult();
            //assert
            // Assert.True(rover.direction == "E");
            Assert.AreEqual(3, rover.y);
        }
        [TestMethod]

        public void Move()
        {
            //arrange
            RoverDTO rover = new RoverDTO();
            rover.x = 1;
            rover.y = 2;
            var result = rover.direction = "N";
            //act
            result = _roverService.Move(rover, "LMLMLMLMM").GetAwaiter().GetResult();
            //assert
            // Assert.True(rover.direction == "E");
            Assert.AreEqual("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}