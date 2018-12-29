using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Ground : Asset
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_ground.png";

        public Ground() : base()
        {
        }

        public Ground(Size size) : base(size)
        {
        }

        public Ground(Position position) : base(position)
        {
        }

        public Ground(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
