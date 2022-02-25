using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Entities;

internal class RoverPosition
{
    public int XPoint{ get; set; }
    public int YPoint { get; set; }
    public Direction Direction { get; set; }
}