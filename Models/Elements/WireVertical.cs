using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class WireVertical : Wire
    {
        protected override string FileName { get; set; } = "element_wire_vertical.png";
        public override Size Size { get; protected set; } = new Size(Wire.Thickness, 1);

        public WireVertical(Connection parentLine) : base(parentLine)
        {
        }

        public WireVertical(Size size, Connection parentLine) : base(size, parentLine)
        {
        }

        public WireVertical(Position position, Connection parentLine) : base(position, parentLine)
        {
        }

        public WireVertical(Size size, Position position, Connection parentLine) : base(size, position, parentLine)
        {
        }
    }
}