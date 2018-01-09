using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    sealed class Apple : GameObject
    {
        public Apple(Point pos)
        {
            Pos.X = pos.X;
            Pos.Y = pos.Y;
            RenderData.Image = '@';
            RenderData.Color = ConsoleColor.Red;
            Speed.XVector = 0;
            Speed.YVector = 0;
        }
    }
}
