using System;

namespace task1;

internal class Program
{
  static void Main(string[] args)
  {
    Student s1 = new Student();
    s1.name = "ram";
    s1.age = 1;
    s1.id = 101;

    Console.WriteLine($"Name: {s1.name} Age: {s1.age} Id: {s1.id}");

    Student s2 = new Student();
    s2.name = "hari";
    s2.age = 2;
    s2.id = 102;

    Console.WriteLine($"Name: {s2.name} Age: {s2.age} Id: {s2.id}");

    Console.WriteLine(Student.section);
  }
}
