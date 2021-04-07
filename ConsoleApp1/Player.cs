using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Player
    {
        public int CurrentHealth { get; set; }
        public List<String> Items { get; set; }
        public Location Location { get; set; }

        public void InitPlayer(int width, int height)
        {
            Random r = new Random();
            int randomX = r.Next(width);
            int randomY = r.Next(height);

            Location = new Location();

            Location.X = randomX;
            Location.Y = randomY;

            Items = new List<string>();

            Console.WriteLine("Player is at " + randomX + "," + randomY + ".");
        }

        public void Use()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("You have no items you can use.");
            } 
        }

        public void Move(String direction)
        {
            switch (direction)
            {
                case "north":
                    Console.WriteLine("Moved " + direction + ".");
                    Console.WriteLine("Was at " + Location.X + "," + Location.Y + ".");
                    Location.Y = Location.Y < 9 ? Location.Y + 1 : Location.Y;
                    Console.WriteLine("Is now at " + Location.X + "," + Location.Y + ".");
                    break;
                case "south":
                    Console.WriteLine("Moved " + direction + ".");
                    Console.WriteLine("Was at " + Location.X + "," + Location.Y + ".");
                    Location.Y = Location.Y > 0 ? Location.Y  - 1 : Location.Y;
                    Console.WriteLine("Is now at " + Location.X + "," + Location.Y + ".");
                    break;
                case "east":
                    Console.WriteLine("Moved " + direction + ".");
                    Console.WriteLine("Was at " + Location.X + "," + Location.Y + ".");
                    Location.X = Location.X < 9 ? Location.X + 1 : Location.X;
                    Console.WriteLine("Is now at " + Location.X + "," + Location.Y + ".");
                    break;
                case "west":
                    Console.WriteLine("Moved " + direction + ".");
                    Console.WriteLine("Was at " + Location.X + "," + Location.Y + ".");
                    Location.X = Location.X > 0 ? Location.X - 1 : Location.X;
                    Console.WriteLine("Is now at " + Location.X + "," + Location.Y + ".");
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;

            }
        } 

    }
}
