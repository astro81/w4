using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

          Console.Write("Enter marks: ");
          string? marksI = Console.ReadLine();
          bool isMarksValid = int.TryParse(marksI, out int marks);

          if (!isMarksValid)
          {
            Console.WriteLine("Marks is not valid");
            return;
          }

          Console.Write("Enter total: ");
          string? totalI = Console.ReadLine();
          bool isTotalValid = int.TryParse(totalI, out int total);

          if (!isTotalValid || total == 0)
          {
            Console.WriteLine("Total is not valid");
            return;
          }

          // double percentage = marks / total * 100;
          double percentage = (double)marks / total * 100;

          Console.WriteLine($"Percentage: {percentage}");

        }
    }
}

/*
 * While initially running the program got
 * Enter marks: 75
 * Enter total: 90
 * Percentage: 0
 *
 *
 * The program is returning the wrong result
 * 
 * Why is the output incorrect?
 *
 * double percentage = marks / total * 100;
 * causes integer division because both marks and total are integers. In C#, integer division truncates the decimal part.
 * Here: 75 / 90 = 0 (integer division)
 * 0 * 100 = 0
 *
 * 
 * How can we correct the program?
 *
 * By casting one operand to double
 * double percentage = (double)marks / total * 100;
 *
 * Enter marks: 75
 * Enter total: 90
 * Percentage: 83.333333333333334
 *
 */
