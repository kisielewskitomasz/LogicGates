using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Pin
    {
        public static int Width = 6;
        public static int Height = 6;
        public Element Element = null;
        public IO Type { get; set; } = IO.Null;
        public Size Size { get; protected set; } = new Size(Width, Height);
        public Position Position { get; protected set; } = null;
        public Connection ParentConnection { get; set; } = null;
        public bool isConnected = false;

        public Pin(int width, int height, IO type)
        {
            Position = new Position (width, height);
            Type = type;
        }
    }
}
