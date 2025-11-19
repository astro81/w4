using System;

namespace task2;

internal class Program
{
  static void Main(string[] args)
  {
    ParameterDemo demo = new ParameterDemo();

    int n = 5;
    demo.Increase(ref n);
    Console.WriteLine($"Increase: {n}");

    demo.GetFullName(out string name);
    Console.WriteLine($"Full name: {name}");

    Console.WriteLine($"Sum: {demo.SumAll(1, 2, 3, 4)}");
  }
}
