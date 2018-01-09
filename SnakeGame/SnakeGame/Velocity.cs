namespace SnakeGame
{
    public class Velocity
    {
        public int XVector { get; set; }
        public int YVector { get; set; }

        public Velocity() { }

        public Velocity(int xSpeed, int ySpeed)
        {
            XVector = xSpeed;
            YVector = ySpeed;
        }
    }
}