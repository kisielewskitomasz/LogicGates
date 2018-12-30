namespace LogicGates.Common
{
    public class Point {
        public int Width;
        public int Height;

        public static Point operator+ (Point a, Point b) {
            Point point = new Point();
            point.Width = a.Width + b.Width;
            point.Height = a.Height + b.Height;
            return point;
        }

        public static Point operator- (Point a, Point b) {
            Point point = new Point();
            point.Width = a.Width - b.Width;
            point.Height = a.Height - b.Height;
            return point;
        }
    }
}