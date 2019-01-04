using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class WireHorizontal : Wire
    {
        protected override string FileName { get; set; } = "element_wire_horizontal.png";
        public override Size Size { get; protected set; } = new Size(1, 6);

        public WireHorizontal(Connection parentLine) : base(parentLine)
        {
        }

        public WireHorizontal(Size size, Connection parentLine) : base(size, parentLine)
        {
        }

        public WireHorizontal(Position position, Connection parentLine) : base(position, parentLine)
        {
        }

        public WireHorizontal(Size size, Position position, Connection parentLine) : base(size, position, parentLine)
        {
        }
    }
}