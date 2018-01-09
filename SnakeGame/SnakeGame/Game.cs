using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    enum GameObjectType
    {
        SnakeHead,
        SnakeSegment,
        Apple
    }

    enum Direction
    {
        north,
        east,
        south,
        west
    }

    class Game
    {
        List<GameObject> gameObjects = new List<GameObject>();
        private int xBounds = 60;
        private int yBounds = 25;
        private int[,] world;
        private ConsoleKey key;
        Direction dir = Direction.east;

        private bool finished = false;

        public bool Finished
        {
            get { return finished; }
        }


        public Game(int xBounds, int yBounds)
        {
            this.xBounds = xBounds;
            this.yBounds = yBounds;
            world = new int[xBounds, yBounds];
        }

        public void ReadInput()
        {
            try
            {
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                }
            }
            catch { }

            // Change snakeheads direction speed etc.

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

        public void Update()
        {
            // If there is no apple spawn one
            if (!gameObjects.OfType<Apple>().Any())
            {
                Spawn(GameObjectType.Apple);
            }
            // First update the snake head
            SnakeHead head = gameObjects.OfType<SnakeHead>().First();
            // Set heads previous position
            int prevX = head.Pos.X;
            int prevY = head.Pos.Y;
            // update heads position
            head.Update();

            // Update the entire body segment by segment
            foreach(SnakeSegment body in gameObjects)
            {
                body.Update();
                body.Pos.X = prevX;
                body.Pos.Y = prevY;
                prevX = body.PrevX;
                prevY = body.PrevY;
            }

            throw new NotImplementedException();
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

        public void Spawn(GameObjectType type)
        {
            switch (type)
            {
                case GameObjectType.SnakeHead:
                    gameObjects.Add(new SnakeHead());
                    break;
                case GameObjectType.SnakeSegment:
                    gameObjects.Add(new SnakeSegment(new Point(100,100)));
                    break;
                case GameObjectType.Apple:
                    Random rng = new Random();
                    int x = rng.Next(xBounds);
                    int y = rng.Next(yBounds);
                    gameObjects.Add(new Apple(new Point(x,y)));
                    break;
            }
        }
    }
}
