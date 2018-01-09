using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // initialize the game

            Game game = new Game(60, 25);
            game.FillWorld();
            Console.ReadLine();

            while (true)
            {
                // ReadInput
                try
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                    }
                }
                catch { }
                // Update Gamestate
                // Render
            }
            
        }

        


    }
}
