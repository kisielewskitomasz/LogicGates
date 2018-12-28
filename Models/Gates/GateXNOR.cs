using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXNOR : Gate
    {
        protected override string FileName { get; set; } = "symbol_xnor.png";

        public GateXNOR() : base()
        {
        }

        public GateXNOR(Size size) : base(size)
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
