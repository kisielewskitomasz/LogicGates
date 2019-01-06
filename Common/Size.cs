namespace LogicGates.Common
{
    /// <summary>
    /// Defines Size of Asset on Canvas
    /// </summary>
    public class Size : Point
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Size() : base()
        {
        }

        /// <summary>
        /// Construct Size with width and height
        /// </summary>
        /// <param name="width">Width of Size</param>
        /// <param name="height">Height of Size</param>
        public Size(int width, int height) : base(width, height)
        {
        }

        /// <summary>
        /// Adds Point to Size
        /// </summary>
        /// <param name="a">First Size</param>
        /// <param name="b">Second Point</param>
        /// <returns>New Size</returns>
        public static Size operator +(Size a, Point b)
        {
            return new Size(a.Width + b.Width, a.Height + b.Height); ;
        }

        /// <summary>
        /// Substract Point from Size
        /// </summary>
        /// <param name="a">First Size</param>
        /// <param name="b">Second Point</param>
        /// <returns>New Size</returns>
        public static Size operator -(Size a, Point b)
        {
            return new Size(a.Width - b.Width, a.Height - b.Height); ;
        }
    }
}