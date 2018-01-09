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
        static int points = 0;
        List<GameObject> gameObjects = new List<GameObject>();
        private int xBounds = 60;
        private int yBounds = 25;
        private int[,] world;
        private ConsoleKey key;
        private Direction dir = Direction.east;
        private bool finished = false;
        private SnakeHead head;
        private Apple apple;

        public Direction Dir
        {
            get { return dir; }
        }

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

        public void GameOverScreen()
        {
            Console.Clear();
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
            Console.WriteLine("  Thanks so much for testing my  ");
            Console.WriteLine("       home made snake game.     ");
            Console.WriteLine("      You scored {0} points!     ",points);
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
            Console.ReadLine();
        }

        public void ReadInput()
        {
            try
            {
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                }
            }
            catch { }

            // Change snakeheads direction speed etc.
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    dir = Direction.west;
                    head.Speed.XVector = -1;
                    head.Speed.YVector = 0;
                    break;
                case ConsoleKey.UpArrow:
                    dir = Direction.north;
                    head.Speed.XVector = 0;
                    head.Speed.YVector = -1;
                    break;
                case ConsoleKey.RightArrow:
                    dir = Direction.east;
                    head.Speed.XVector = 1;
                    head.Speed.YVector = 0;
                    break;
                case ConsoleKey.DownArrow:
                    dir = Direction.south;
                    head.Speed.XVector = 0;
                    head.Speed.YVector = 1;
                    break;
            }

        }

        // Renders every gameobject
        public void Render()
        {
            // Clear the window
            Console.Clear();
            RenderWalls();
            // Draw every object
            if (gameObjects.Count > 0)
            {
                foreach (var obj in gameObjects)
                {
                    obj.Render();
                }
            }
            apple.Render();
            head.Render();
        }

        private void RenderWalls()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int x = 0; x < xBounds; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("#");
                Console.SetCursorPosition(x, yBounds);
                Console.Write("#");
            }
            for (int y = 0; y < yBounds; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("#");
                Console.SetCursorPosition(xBounds, y);
                Console.Write("#");
            }
        }

        public void Update()
        {
            // Set heads previous position
            int prevX = head.Pos.X;
            int prevY = head.Pos.Y;
            // Update heads position
            head.Update();

            // Update the entire body segment by segment
            // Also check if we have collided with the body
            foreach(SnakeSegment body in gameObjects)
            {
                if (head.Pos.X == body.Pos.X && head.Pos.Y == body.Pos.Y)
                {
                    finished = true;
                }
                body.Update();
                body.Pos.X = prevX;
                body.Pos.Y = prevY;
                prevX = body.PrevX;
                prevY = body.PrevY;
                
            }
            // Check if we have eaten an yummy apple
            // If we have add more snake bodyparts and remove the apple.
            if(head.Pos.X == apple.Pos.X && head.Pos.Y == apple.Pos.Y)
            {
                Spawn(GameObjectType.SnakeSegment);
                points++;
                Spawn(GameObjectType.Apple);
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

        public void Spawn(GameObjectType type)
        {
            switch (type)
            {
                case GameObjectType.SnakeHead:
                    head = new SnakeHead();
                    break;
                case GameObjectType.SnakeSegment:
                    gameObjects.Add(new SnakeSegment(new Point(100,100)));
                    break;
                case GameObjectType.Apple:
                    Random rng = new Random();
                    int x = rng.Next(xBounds);
                    int y = rng.Next(yBounds);
                    apple = new Apple(new Point(x, y));
                    break;
            }
        }
    }
}
