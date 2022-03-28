using MarsRover.Entities;

namespace MarsRover.Implementations;

internal class EastDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public EastDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward()
    {
        var tmpPosition = Position.XPoint + 1;

        var existingRover = Plateau.Rovers.Any(x => x.RoverPosition?.XPoint == tmpPosition);

        if (existingRover) throw new Exception("You cannot move this rover. Because there is an another rover at that point");

        if(tmpPosition <= Position.XPoint) Position.XPoint += 1;
        else throw new Exception("You cannot move this rover. Out of plateau");
    }

    public IRoverDirectives TurnLeft()
    {
        Position.Direction = Direction.N;
        return new NorthDirection(Position);
    }

    public IRoverDirectives TurnRight()
    {
        Position.Direction = Direction.S;
        return new SouthDirection(Position);
    }
}