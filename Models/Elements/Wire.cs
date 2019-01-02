using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Wire : Element
    {
        protected override string FileName { get; set; } = "element_wire.png";
        public override Size Size { get; protected set; } = new Size(1, 6);

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
    }
}