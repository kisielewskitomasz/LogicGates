using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOR : Gate
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "gate_nor.png";

        public GateNOR() : base()
        {
        }

        public GateNOR(Size size) : base(size)
        {
        }

        public GateNOR(Position position) : base(position)
        {
        }

        public GateNOR(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
