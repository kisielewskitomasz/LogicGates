namespace LogicGates.Common
{
    public class Point {
        public int Width;
        public int Height;

        public Point()
        {

        }

        public Point(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static Point operator+ (Point a, Point b) {
            return new Point(a.Width + b.Width, a.Height + b.Height);;
        }

        public static Point operator- (Point a, Point b) {
            return new Point(a.Width - b.Width, a.Height - b.Height);;
        }
    }
}