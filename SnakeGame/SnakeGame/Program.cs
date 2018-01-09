using System;
using System.Diagnostics;
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
            Stopwatch sw = new Stopwatch();
            long wait;
            long speed = 250;
            Game game = new Game(60, 25);
            game.Spawn(GameObjectType.SnakeHead);
            game.Spawn(GameObjectType.Apple);
            //testRender();

            //Console.ReadLine();
            //testGameOver();
            sw.Start();
            while(!game.Finished)
            {
                // wait for t time if facing north or south
                // wait for t/2 time if facing east or west
                if(game.Dir == Direction.east || game.Dir == Direction.west)
                {
                    wait = speed/2;
                }
                else
                {
                    wait = speed;
                }
                long now = sw.ElapsedMilliseconds;
                // Read input at all times even while waiting
                while(now+wait > sw.ElapsedMilliseconds)
                {
                    game.ReadInput();
                }
                
                // Update the game
                game.Update();
                // Render the game
                game.Render();

            }
            game.GameOverScreen();
            
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

        private static void testGameOver()
        {
            Game game3 = new Game(60, 25);
            game3.GameOverScreen();
        }

        


    }
}
