using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Pin
    {
        public Element Element = null;
        public IO Type { get; set; } = IO.Null;
        public Size Size { get; protected set; } = new Size(8, 6);
        public Position Position { get; protected set; } = null;

        public Pin(int width, int height, IO type)
        {
            Position = new Position (width, height);
            Type = type;
        }
    }
}
