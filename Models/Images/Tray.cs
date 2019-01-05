using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Tray : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Tray.Width, Dimensions.Tray.Height);
        protected override string[] FileNames { get; set; } = { "image_tray.png" };

        public Tray() : base()
        {
        }

        public Tray(Size size) : base(size)
        {
        }

        public Tray(Position position) : base(position)
        {
        }

        public Tray(Size size, Position position) : base(size, position)
        {
        }
    }
}