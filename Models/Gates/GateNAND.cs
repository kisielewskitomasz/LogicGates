using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNAND : Gate
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_nand.png";

        public GateNAND() : base()
        {
        }

        public GateNAND(Size size) : base(size)
        {
        }

        public GateNAND(Position position) : base(position)
        {
        }

        public GateNAND(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
