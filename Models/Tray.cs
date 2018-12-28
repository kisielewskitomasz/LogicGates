using LogicGates.Common;

namespace LogicGates.Models
{
    public class Tray : Asset
    {
        protected override string FileName { get; set; } = "tray.png";

        public Tray() : base()
        {
        }

        public Tray(Size size) : base(size)
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