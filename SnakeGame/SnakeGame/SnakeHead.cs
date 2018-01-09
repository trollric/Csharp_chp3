using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    sealed class SnakeHead : GameObject
    {
        // Fields and properties
        List<SnakeSegment> body = new List<SnakeSegment>();
        public SnakeHead() : base(new Point(10,10), new Velocity(1,0), new Graphic('O',ConsoleColor.Green))
        {

        }

        public override void Update()
        {
            Pos.X += Speed.XVector;
            Pos.Y += Speed.YVector;

            base.Update();
        }
    }
}
