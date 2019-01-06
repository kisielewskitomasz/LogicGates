namespace LogicGates.Common
{
    /// <summary>
    /// Defines Position of Asset on Canvas
    /// </summary>
    public class Position : Point
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Position() : base()
        {
        }

        /// <summary>
        /// Construct Position with width and height
        /// </summary>
        /// <param name="width">Width of Point</param>
        /// <param name="height">Height of Point</param>
        public Position(int width, int height) : base(width, height)
        {
        }

        /// <summary>
        /// Adds Point to Position
        /// </summary>
        /// <param name="a">First Position</param>
        /// <param name="b">Second Point</param>
        /// <returns>New Position</returns>
        public static Position operator +(Position a, Point b)
        {
            return new Position(a.Width + b.Width, a.Height + b.Height); ;
        }

        /// <summary>
        /// Substract Point from Position
        /// </summary>
        /// <param name="a">First Position</param>
        /// <param name="b">Second Point</param>
        /// <returns>New Position</returns>
        public static Position operator -(Position a, Point b)
        {
            return new Position(a.Width - b.Width, a.Height - b.Height); ;
        }
    }
}