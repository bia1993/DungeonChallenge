using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enemy
    {
        public Location Location { get; set; }
        int width;
        int height;

        public void InitEnemy(int width, int height)
        {
            this.width = width;
            this.height = height;

            Random r = new Random();
            int randomX = r.Next(width);
            int randomY = r.Next(height);

            Location = new Location();

            Location.X = randomX;
            Location.Y = randomY;
            
            Console.WriteLine("Enemy is at " + randomX + "," + randomY + ".");
        }

        public void MoveEnemy()
        {
            Random r = new Random();
            int randomX = r.Next(width);
            int randomY = r.Next(height);

            Location.X = randomX;
            Location.Y = randomY;
            Console.WriteLine("Enemy is now at " + randomX + "," + randomY + ".");
        }
        public bool CheckIfAdjToPlayer(Location playerLocation)
        {
            bool isAdj = false;
            
            if ((playerLocation.X + 1 == Location.X && playerLocation.Y == Location.Y) ||
                (playerLocation.X - 1 == Location.X && playerLocation.Y == Location.Y) ||
                (playerLocation.Y + 1 == Location.Y && playerLocation.X == Location.X) ||
                (playerLocation.Y - 1 == Location.Y && playerLocation.X == Location.X)
                )
            {
                isAdj = true;
            }

            return isAdj;
        }
    }
}
