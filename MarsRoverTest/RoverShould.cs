using MarsRover.Data;
using MarsRover.Interface;

namespace MarsRoverTest
{
    public class RoverShould
    {
        private readonly IRoverService _roverService;
        public RoverShould(IRoverService roverService)
        {
            _roverService = roverService;
        }
        [Fact]
        public void SpinLeft()
        {
            //arrange
            RoverDTO rover = new RoverDTO();
            rover.x = 1;
            rover.y = 2;
         var result=   rover.direction = "N";
            //act
       result =     _roverService.SpinLeft(rover).GetAwaiter().GetResult(); 
            //assert
          //  Assert.True(rover.direction == "W");
             Assert.Equal("W", result);
        }
        [Fact]
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
            Assert.True(rover.direction == "E");
            //  Assert.Equal("W", rover.direction);
        }
        [Fact]
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
            Assert.Equal(3, rover.y);
        }
        [Fact]
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
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}