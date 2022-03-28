using MarsRover.Implementations;

namespace MarsRover.Entities;

internal class Rover : IRoverCommand
{
    public RoverPosition? RoverPosition { get; private set; }

    private IRoverDirectives _directives;

    public Rover(IRoverDirectives directives)
    {
        _directives = directives;
    }

    public RoverPosition Move(Command command)
    {
        switch (command)
        {
            case Command.L: 
                _directives = _directives.TurnLeft();
                break;
            case Command.R:
                _directives = _directives.TurnRight();
                break;
            case Command.M:
                //if ((_directives.Position.XPoint <= Plateau.XEdge && _directives.Position.YPoint <= Plateau.YEdge))
                    _directives.MoveForward();
                break;
            default: throw new ArgumentException("Invalid move command");
        }

        RoverPosition = _directives.Position;

        return RoverPosition;
    }
}