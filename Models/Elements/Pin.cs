using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Pin
    {
        public static int Width = Dimensions.Element.Pin.Width;
        public static int Height = Dimensions.Element.Pin.Height;
        public Element Element = null;
        public Defs.Pin Type { get; set; } = Defs.Pin.Null;
        public Size Size { get; protected set; } = new Size(Width, Height);
        public Position Position { get; protected set; } = null;
        public Connection ParentConnection { get; set; } = null;
        public bool isConnected = false;

        public Pin(int width, int height, Defs.Pin type)
        {
            Position = new Position (width, height);
            Type = type;
        }
    }
}
