using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Defines Pin object
    /// </summary>
    public class Pin
    {
        /// <summary>Keeps parent Element of Pin</summary>
        public Element Element = null;
        /// <summary>Keeps Pint type</summary>
        public Defs.Pin Type { get; set; } = Defs.Pin.Null;
        /// <summary>Keeps Pin Size</summary>
        public Size Size { get; protected set; } = new Size(Dimensions.Element.Pin.Height, Dimensions.Element.Pin.Width);
        /// <summary>Keeps Pin Position</summary>
        public Position Position { get; protected set; } = null;
        /// <summary>Keeps parent Connection of Pin</summary>
        public Connection ParentConnection { get; set; } = null;
        /// <summary>Keeps info about connection exist</summary>
        public bool isConnected = false;

        /// <summary>
        /// Constructs Asset with given width, height of Position and type
        /// </summary>
        /// <param name="width">Width Position of Pin</param>
        /// <param name="height">Height Position of Pin</param>
        /// <param name="type">Type of Pin</param>
        public Pin(int width, int height, Defs.Pin type)
        {
            Position = new Position (width, height);
            Type = type;
        }
    }
}
