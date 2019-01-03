namespace LogicGates.Common
{
    public class Position : Point
    {
        public Position() : base()
        {
        }

        public Position(int width, int height) : base(width, height)
        {
        }

        public static Position operator +(Position a, Point b)
        {
            return new Position(a.Width + b.Width, a.Height + b.Height); ;
        }

        public static Position operator -(Position a, Point b)
        {
            return new Position(a.Width - b.Width, a.Height - b.Height); ;
        }
    }
}