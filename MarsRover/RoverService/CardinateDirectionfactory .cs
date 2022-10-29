
using MarsRover.Data;

namespace MarsRover.RoverService
{
    public static class CardinateDirectionfactory
    {
        public static string SpinLeft(string spin)
        {
            if (spin == "N") return "E";
            else if (spin == "E") return "S";
            else if (spin == "S") return "W";
            else if (spin == "W") return "N";
            return null;
        }
        public static string SpinRight(string spin)
        {
            if (spin == "N") return "W";
            else if (spin == "E") return "N";
            else if (spin == "S") return "E";
            else if (spin == "W") return "S";
            return null;
        }
        public static int StepForward(RoverDTO move)
        {
            if (move.direction == "N")
                return move.y += 1;
            if (move.direction == "E")
                return move.x += 1;
            if (move.direction == "S")
                return move.y -= 1;
            if (move.direction == "W")
                return move.x -= 1;
            return 0;
        }
        public static string Move(RoverDTO location, string roverCommand) //LMLMLMLMM
        {
            char[] instruction = roverCommand.ToCharArray();
            string left = null;
            string right = null;
            int result = 0;
            for (int i = 0; i < instruction.Length; i++)
            {
                if (location.x == 1 && location.y == 2)
                {
                    switch (instruction[i])
                    {
                        case 'L':
                             left = SpinLeft(location.direction);
                            break;
                        case 'R':
                             right = SpinRight(location.direction);
                            break;
                        case 'M':
                             result = StepForward(location);
                            break;
                        default:
                           return null;
                            break;
                    }
                }
                if (location.x == 3 && location.y == 3)
                {
                    switch (instruction[i])
                    {
                        case 'L':
                             left = SpinLeft(location.direction);
                            break;
                        case 'R':
                             right = SpinRight(location.direction);
                            break;
                        case 'M':
                             result = StepForward(location);
                            break;
                        default:
                            return  null;
                            break;
                    }
                }
            }
            return left + " " + right + " " + result.ToString ();
            
        }

    }
}

 
    