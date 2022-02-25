using MarsRover.Entities;

namespace MarsRover.Implementations;

internal interface IRoverCommand
{
    RoverPosition Move(Command command);
}