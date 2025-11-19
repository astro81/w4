using System;

namespace task3
{
    internal class Program
    {
      static void Main(string[] args)
      {
        Calculator cal = new Calculator();

        cal.PrintWelcome();
        Console.WriteLine($"Sum: {cal.Add(2, 3)}");
        Console.WriteLine($"Mul: {cal.Multiply(4, 5)}");
      }
    }

    class Calculator
    {
      public void PrintWelcome()
      {
        Console.WriteLine("Welcome to Calculator");
      }

      public int Add(int num1, int num2)
      {
        return num1 + num2;
      }

      public int Multiply(int num1, int num2 = 1)
      {
        return num1 * num2;
      }
    }
}
