﻿namespace MarsRover.Entities;

internal static class Plateau
{
    public static int XEdge { get; set; }
    public static int YEdge { get; set; }
    public static List<Rover> Rovers { get; set; } = new List<Rover>();
}