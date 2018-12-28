using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateAND : Gate
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_and.png";

        public GateAND() : base()
        {
        }

        public GateAND(Size size) : base(size)
        {
        }

        public GateAND(Position position) : base(position)
        {
        }

        public GateAND(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
