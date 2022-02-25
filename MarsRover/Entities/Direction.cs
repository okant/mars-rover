using System.ComponentModel.DataAnnotations;

namespace MarsRover.Entities;

public enum Direction
{
    [Display(Name = "North")]
    N = 0,
    [Display(Name = "East")]
    E = 1,
    [Display(Name = "South")]
    S = 2,
    [Display(Name = "West")]
    W = 3
}