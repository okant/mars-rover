using MarsRover.Entities;

namespace MarsRover.Implementations;

internal class NorthDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public NorthDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward()/* => Position.YPoint += 1;*/
    {
        var tmpPosition = Position.YPoint + 1;

        var existingRover = Plateau.Rovers.Any(x => x.RoverPosition?.YPoint == tmpPosition);

        if (existingRover) throw new Exception("You cannot move this rover. Because there is an another rover at that point");

        if (tmpPosition <= Position.YPoint) Position.YPoint += 1;
        else throw new Exception("You cannot move this rover. Out of plateau");
    }

    public IRoverDirectives TurnLeft()
    {
        Position.Direction = Direction.W;
        return new WestDirection(Position);
    }

    public IRoverDirectives TurnRight()
    {
        Position.Direction = Direction.E;
        return new EastDirection(Position);
    }
}