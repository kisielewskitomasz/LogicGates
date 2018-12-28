using LogicGates.Common;

namespace LogicGates.Models.Screens
{
    public class Tray : Asset
    {
        public override Size Size { get; protected set; } = new Size {Width = 1024, Height = 64};
        protected override string FileName { get; set; } = "tray.png";

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

        public override void Clicked(Position mousePosition)
        {
        }
    }
}