using MarsRover.Data;

namespace MarsRover.Interface
{
    public interface IRoverService
    {
        Task<string> SpinRight(RoverDTO roverDTO);
        Task<string> SpinLeft(RoverDTO roverDTO);
        Task<int> StepForward(RoverDTO roverDTO);
        Task<string> Move(RoverDTO location, string roverCommand);
    }
}
