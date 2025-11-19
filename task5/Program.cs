using System;

namespace task5
{
  
  enum DayType
  {
    WeekDay,
    Weekend
  }

  public record Book(string title, string author, double price);

  internal class Program
  {  
    static void Main(string[] args)
    {
      Console.Write("Enter day: ");
      string? day = Console.ReadLine();

      DayType dayType;

      if (string.Equals(day.ToLower(), "friday") || string.Equals(day.ToLower(), "saturday"))
      {
        dayType = DayType.Weekend;
      }
      else
      {
        dayType = DayType.Weekend;
      }

      Console.WriteLine($"It is: {dayType}");



      Book book1 = new Book("C#", "ram", 10.4);

      Book book2 = book1 with { title="py", price = 30.2 };

      Console.WriteLine($"Book1 title: {book1.title} author: {book1.author} price: {book1.price}");

      var (title, author, price) = book2;

      Console.WriteLine($"Book2 title: {book2.title} author: {book2.author} price: {book2.price}");

    }

  }

}



