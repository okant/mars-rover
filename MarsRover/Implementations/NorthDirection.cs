using MarsRover.Entities;

namespace MarsRover.Implementations;

internal class NorthDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public NorthDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward() => Position.YPoint += 1;

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