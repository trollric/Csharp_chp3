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
            game.Spawn(GameObjectType.SnakeHead);
            game.Spawn(GameObjectType.Apple);
            testRender();

            Console.ReadLine();

            while(!game.Finished)
            {
                // wait for t time if facing north or south
                // wait for t/2 time if facing east or west

                // ReadInput uf possible
                game.ReadInput();
                // Update the game
                game.Update();
                // Render the game
                game.Render();

            }
            
        }

        private static void testRender()
        {
            Game game2 = new Game(60,25);
            game2.Spawn(GameObjectType.SnakeHead);
            game2.Spawn(GameObjectType.Apple);
            SnakeSegment seg = new SnakeSegment(new Point(14, 14));
            game2.Render();
            seg.Render();
        }

        


    }
}
