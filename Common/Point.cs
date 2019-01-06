namespace LogicGates.Common
{
    /// <summary>
    /// Defines Point on Canvas
    /// </summary>
    public class Point
    {
        /// <summary>Keeps Point Widith</summary>
        public int Width;
        /// <summary>Keeps Point Height</summary>
        public int Height;

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Point()
        {

        }

        /// <summary>
        /// Construct Point with width and height
        /// </summary>
        /// <param name="width">Width of Point</param>
        /// <param name="height">Height of Point</param>
        public Point(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Adds two points
        /// </summary>
        /// <param name="a">First point</param>
        /// <param name="b">Second point</param>
        /// <returns>New Point</returns>
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.Width + b.Width, a.Height + b.Height); ;
        }

        /// <summary>
        /// Substract two points
        /// </summary>
        /// <param name="a">First point</param>
        /// <param name="b">Second point</param>
        /// <returns>New Point</returns>
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.Width - b.Width, a.Height - b.Height); ;
        }
    }
}