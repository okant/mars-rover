using MarsRover.Entities;
using MarsRover.Implementations;

Console.WriteLine("Enter the plateau coordinates");

var plateauCoordinates = Console.ReadLine();

if (string.IsNullOrEmpty(plateauCoordinates)) throw new Exception("Plateau Coordinates are not entered.");

var coordinates = plateauCoordinates.Split(" ");

if (coordinates.Length == Constants.EdgeLength)
{
    var xLimitConverted = int.TryParse(coordinates[Constants.X].ToString(), out var xLimit);
    var yLimitConverted = int.TryParse(coordinates[Constants.Y].ToString(), out var yLimit);

    if (!xLimitConverted) throw new Exception("Plateau Coordinates[X] is not valid.");
    if (!yLimitConverted) throw new Exception("Plateau Coordinates[Y] is not valid.");

    if (xLimit < 0) throw new Exception("Plateau Coordinates[X] is not valid.");
    if (yLimit < 0) throw new Exception("Plateau Coordinates[Y] is not valid.");

    Plateau.XEdge = xLimit;
    Plateau.YEdge = yLimit;

    Console.WriteLine("Locate Rover on the plateau");

    var positionAndDirection = Console.ReadLine();

    if(string.IsNullOrEmpty(positionAndDirection)) throw new Exception("Rover not located on plateau");

    var locationItems = positionAndDirection.Split(" ");

    if (locationItems.Length == Constants.PositionLength)
    {
        var xConverted = int.TryParse(locationItems[Constants.X].ToString(), out var xLocation);
        var yConverted = int.TryParse(locationItems[Constants.Y].ToString(), out var yLocation);
        var directionConverted = Enum.TryParse(locationItems[Constants.PositionPoint].ToString().ToUpper(), out Direction direction);

        if(xConverted && yConverted && directionConverted)
        {
            if (xLocation > Plateau.XEdge)
                throw new ArgumentOutOfRangeException("Cannot locate rover to this point");
            if (yLocation > Plateau.YEdge)
                throw new ArgumentOutOfRangeException("Cannot locate rover to this point");

            var roverPosition = new RoverPosition { Direction = direction, XPoint = xLocation, YPoint = yLocation };
            var rover = roverPosition.Direction switch
            {
                Direction.N => new Rover(new NorthDirection(roverPosition)),
                Direction.E => new Rover(new EastDirection(roverPosition)),
                Direction.W => new Rover(new WestDirection(roverPosition)),
                Direction.S => new Rover(new SouthDirection(roverPosition)),
                _ => throw new InvalidDataException("The direction entered is not valid."),
            };

            Console.WriteLine("Move the rover..");

            var commands = Console.ReadLine();

            if(string.IsNullOrEmpty(commands)) 
                throw new Exception("Move command or commands must be entered");

            commands.ToList().ForEach(x => {
                var command = (Command)Enum.Parse(typeof(Command), x.ToString().ToUpper());
                rover.Move(command);
            });

            if (rover.RoverPosition != null)
                Console.WriteLine(rover.RoverPosition.XPoint + " " + rover.RoverPosition.YPoint + " " +
                                  rover.RoverPosition.Direction);

            Console.ReadKey();
        }
        else
            throw new ArgumentOutOfRangeException("Cannot locate rover to this point");
    }
}