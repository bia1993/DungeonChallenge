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

        int width;
        int height;

        public void InitPlayer(int width, int height)
        {
            Random r = new Random();
            int randomX = r.Next(width);
            int randomY = r.Next(height);

            Location = new Location();

            Location.X = randomX;
            Location.Y = randomY;

            this.width = width;
            this.height = height;

            Items = new List<string>();
        }

        public void LoseHealth()
        {
            CurrentHealth--;
            Console.WriteLine("You lost 1 HP.");

            if (CurrentHealth == 0)
            {
                Console.WriteLine("You have been defeated.");
                System.Environment.Exit(1);
            }
        }

        public bool CheckIfHasItem()
        {
            return Items.Count != 0;
        }

        public void Move(String direction)
        {
            switch (direction)
            {
                case "north":
                    Location.Y = Location.Y < height - 1 ? Location.Y + 1 : Location.Y;
                    break;
                case "south":
                    Location.Y = Location.Y > 0 ? Location.Y  - 1 : Location.Y;
                    break;
                case "east":
                    Location.X = Location.X < width - 1 ? Location.X + 1 : Location.X;
                    break;
                case "west":
                    Location.X = Location.X > 0 ? Location.X - 1 : Location.X;
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;

            }
        } 

    }
}
