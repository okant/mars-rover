using System.ComponentModel.DataAnnotations;

namespace MarsRover.Entities;

public enum Command
{
    [Display(Name = "Left")]
    L = 0,
    [Display(Name = "Right")]
    R = 1,
    [Display(Name = "Move")]
    M = 2
}