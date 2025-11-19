using System;

namespace task4
{
    internal class Program
    {
      static void Main(string[] args)
      {
        Player player1 = new Player();

        player1.playerName = "DefaultPlayer";
        player1.level = 1;
        player1.health = 100;

        Console.WriteLine("\nPlayer 1 Details:");
        Console.WriteLine("Name: " + player1.playerName);
        Console.WriteLine("Level: " + player1.level);
        Console.WriteLine("Health: " + player1.health);

        Player player2 = new Player("Hero", 5, 250);

        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Name: " + player2.playerName);
        Console.WriteLine("Level: " + player2.level);
        Console.WriteLine("Health: " + player2.health);
      }
    }

    class Player
    {
      public string? playerName;
      public int? level;
      public int? health;

      public Player()
      {
        Console.WriteLine("Default constructor has been called");
      }

      public Player(string playerName, int level, int health)
      {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
      }
    }
}
