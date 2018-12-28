using LogicGates.Common;

namespace LogicGates.Models
{
    public class Tray : Asset
    {
        public Tray(string fileName) : base(fileName)
        {
        }

        public Tray(string fileName, Size size) : base(fileName, size)
        {
        }

        public Tray(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}