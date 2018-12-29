using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Wire : Asset
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_wire.png";

        public Wire() : base()
        {
        }

        public Wire(Size size) : base(size)
        {
        }

        public Wire(Position position) : base(position)
        {
        }

        public Wire(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}