using MarsRover.Entities;

namespace MarsRover.Implementations;
internal class WestDirection : IRoverDirectives
{
    public RoverPosition Position { get; set; }

    public WestDirection(RoverPosition position)
    {
        Position = position;
    }

    public void MoveForward() => Position.XPoint -= 1;

    public IRoverDirectives TurnLeft()
    {
        Position.Direction = Direction.S;
        return new SouthDirection(Position);
    }

    public IRoverDirectives TurnRight()
    {
        Position.Direction = Direction.N;
        return new NorthDirection(Position);
    }
}