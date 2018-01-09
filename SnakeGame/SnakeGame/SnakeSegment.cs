using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    sealed class SnakeSegment : GameObject
    {
        // Fields and data
        public int PrevX { get; set; }
        public int PrevY { get; set; }

        public SnakeSegment(Point pos) : base(pos, new Velocity(0,0), new Graphic('o',ConsoleColor.DarkGreen))
        {

        }

        public override void Update()
        {
            PrevX = Pos.X;
            PrevY = Pos.Y;
        }
    }
}
