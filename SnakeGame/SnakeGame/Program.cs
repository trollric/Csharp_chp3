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
            char keyPressed = 'd';
            Console.WriteLine("Test to the best");
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

        private void Render()
        {
            // Clear the window
            Console.Clear();
            // Draw every object

            // Use Console.setCursorPosition(x,y)

        }
    }
}
