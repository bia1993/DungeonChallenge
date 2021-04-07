using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }

        Tile[,] Board;
        public void InitMap()
        {
            Random r = new Random();
            int randomX = r.Next(Width);
            int randomY = r.Next(Height);

            Board = new Tile[Width, Height];

            for (int i = 0; i < Width; ++i)
            {
               for (int j = 0; j < Width; ++j)
               {
                    Board[i, j] = new Tile();
               }
            }

            Board[randomX, randomY].Items = new List<string>();
            Board[randomX, randomY].Items.Add("Sword");

            Console.WriteLine("Sword is at " + randomX + "," + randomY + ".");
        }

       public String Search(Location location)
        {
            var tile = Board[location.X, location.Y];

            if (tile.Items != null)
            {
                return tile.Items[0];
            }

            return "";
        }
    }

    class Tile
    {
        public List<String> Items { get; set; }
    }

    
}
