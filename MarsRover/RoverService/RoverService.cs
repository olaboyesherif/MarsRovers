using MarsRover.Interface;
using MarsRover.Data;

namespace MarsRover.RoverService
{
    public class RoverService: IRoverService
    {
        public async Task<string> SpinRight(RoverDTO roverDTO)
        {
            if (roverDTO == null) return null;
            if (roverDTO.x == 1 && roverDTO.y == 2)
            {
                var result = CardinateDirectionfactory.SpinRight(roverDTO.direction);
                return result;
            }
            return null;
        }

        public async Task<string> SpinLeft(RoverDTO roverDTO)
        {
            if (roverDTO == null) return null;
            if(roverDTO.x == 1 && roverDTO .y == 2)
            {
             var result =   CardinateDirectionfactory.SpinLeft(roverDTO.direction);
             return result;
            }
            return null;

        }
        public async Task<int> StepForward(RoverDTO roverDTO)
        {

            if (roverDTO == null) return 0;
            if (roverDTO.x == 1 && roverDTO.y == 2)
            {
                var result = CardinateDirectionfactory.StepForward (roverDTO);
                return result;
            }
            return 0;
        }
        public async Task<string> Move(RoverDTO location,string roverCommand) //LMLMLMLMM
        {
            var result = CardinateDirectionfactory.Move (location, roverCommand);
            return result;
        }
    }
}
