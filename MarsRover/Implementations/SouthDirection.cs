using MarsRover.Entities;

namespace MarsRover.Implementations;

internal class SouthDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public SouthDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward() => Position.YPoint -= 1;

    public IRoverDirectives TurnLeft()
    {
        Position.Direction = Direction.E;
        return new EastDirection(Position);
    }

    public IRoverDirectives TurnRight()
    {
        Position.Direction = Direction.W;
        return new WestDirection(Position);
    }
}