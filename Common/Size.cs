namespace LogicGates.Common
{
    public class Size : Point
    {
        public Size() : base()
        {
        }

        public Size(int width, int height) : base(width, height)
        {
        }

        public static Size operator +(Size a, Point b)
        {
            return new Size(a.Width + b.Width, a.Height + b.Height); ;
        }

        public static Size operator -(Size a, Point b)
        {
            return new Size(a.Width - b.Width, a.Height - b.Height); ;
        }
    }
}