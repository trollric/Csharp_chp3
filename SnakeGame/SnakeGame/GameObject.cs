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

        public GameObject()
        {
            Pos = new Point();
            Speed = new Velocity();
            RenderData = new Graphic();
        }
        public GameObject(Point pos, Velocity vel, Graphic graphic)
        {
            Pos = pos;
            Speed = vel;
            RenderData = graphic;
        }

        public virtual void Render()
        {
            Console.SetCursorPosition(Pos.X, Pos.Y);
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = RenderData.Color;
            Console.Write(RenderData.Image);
            Console.ForegroundColor = prevColor;
        }

        public virtual void Update()
        {

        }
    }
}
