using System;

namespace SnakeGame
{
    public class Graphic
    {
        public char Image { get; set; }
        public ConsoleColor Color { get; set; }

        public Graphic()
        {
            Image = 'x';
            Color = ConsoleColor.White;
        }

        public Graphic(char image, ConsoleColor color)
        {
            Image = image;
            Color = color;
        }
    }
}