using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateOR : Gate
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "gate_or.png";

        public GateOR() : base()
        {
        }

        public GateOR(Size size) : base(size)
        {
        }

        public GateOR(Position position) : base(position)
        {
        }

        public GateOR(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
