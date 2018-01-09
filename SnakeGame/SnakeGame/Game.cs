using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        List<GameObject> gameObjects = new List<GameObject>();
        int xBounds = 60;
        int yBounds = 25;
        int[,] world;

        public Game(int xBounds, int yBounds)
        {
            this.xBounds = xBounds;
            this.yBounds = yBounds;
            world = new int[xBounds, yBounds];
        }

        public void Render()
        {
            // Clear the window
            Console.Clear();
            // Draw every object
            if (gameObjects.Count > 0)
            {
                foreach (var obj in gameObjects)
                {
                    obj.Render();
                }
            }
        }

        public void FillWorld()
        {
            for (int i = 0; i < xBounds; i++)
            {
                for (int y = 0; y < yBounds; y++)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write('o');
                }
            }
        }
    }
}
