using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXNOR : Gate
    {
        public override Size Size { get; protected set; } = new Size { Width = 72, Height = 72 };
        protected override string FileName { get; set; } = "gate_xnor.png";

        public GateXNOR() : base()
        {
        }

        public GateXNOR(Size size) : base(size)
        {
        }

        public GateXNOR(Position position) : base(position)
        {
        }

        public GateXNOR(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
