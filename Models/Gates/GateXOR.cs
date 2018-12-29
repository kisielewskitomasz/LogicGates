using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXOR : Gate
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "gate_xor.png";

        public GateXOR() : base()
        {
        }

        public GateXOR(Size size) : base(size)
        {
        }

        public GateXOR(Size size, Position position) : base(size, position)
        {
        }

        public GateXOR(Position position) : base(position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
