using System;

namespace CpuChoice {
  public class play 
  {
    private Random _r = new Random();
    public int Min { get; } = 1;
    public int Max { get; } = 3;

/// <summary>
/// This function returns the CPU choice as ConsoleKey value of R, P, or S.
/// </summary>
    public System.ConsoleKey shoot()
    {
      var result = _r.Next(Min, Max + 1);
      switch (result) {
        case 1:
          return ConsoleKey.R;
        case 2:
          return ConsoleKey.P;
        case 3:
          return ConsoleKey.S;
        default:
          return ConsoleKey.R;
      }
    }
  }
}