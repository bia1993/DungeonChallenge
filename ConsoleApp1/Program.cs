using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Start! Type a direction to move the character: [north], [south], [east], [west] and [search] to look for an item. Type [Q] to quit.");

            var game = new Game();
            game.Init();

            while(true)
            {
                
                var line = Console.ReadLine();
                game.DecidePlayerAction(line);
                game.TurnCount++;
                game.PerformEnemyActions();

                if (line.Equals("Q"))
                    break;
            }

            Console.WriteLine("End");
        }
    }
}
