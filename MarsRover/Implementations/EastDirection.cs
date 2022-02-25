using MarsRover.Entities;

namespace MarsRover.Implementations;

internal class EastDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public EastDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward() => Position.XPoint += 1;

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