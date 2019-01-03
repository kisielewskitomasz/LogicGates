using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class WireVertical : Wire
    {
        protected override string FileName { get; set; } = "element_wire_vertical.png";
        public override Size Size { get; protected set; } = new Size(1, 6);

        public WireVertical(Line parentLine) : base(parentLine)
        {
        }

        public WireVertical(Size size, Line parentLine) : base(size, parentLine)
        {
        }

        public WireVertical(Position position, Line parentLine) : base(position, parentLine)
        {
        }

        public WireVertical(Size size, Position position, Line parentLine) : base(size, position, parentLine)
        {
        }
    }
}