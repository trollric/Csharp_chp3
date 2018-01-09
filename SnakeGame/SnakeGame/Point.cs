﻿namespace SnakeGame
{
    public class Point
    {
        private int x;
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public Point()
        {

        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

    }
}