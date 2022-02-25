using MarsRover.Entities;

namespace MarsRover.Implementations;

internal interface IRoverDirectives
{
    public RoverPosition Position { get; set; }
    void MoveForward();
    IRoverDirectives TurnLeft();
    IRoverDirectives TurnRight();
}