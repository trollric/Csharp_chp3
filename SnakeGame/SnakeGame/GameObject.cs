using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameObject
    {
        public Point Pos { get; set; }
        public Velocity Speed { get; set; }
        public Graphic RenderData { get; set; }
    }
}
