using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXOR : Gate
    {
        protected override string FileName { get; set; } = "symbol_xor.png";

        public GateXOR() : base()
        {
        }

        public GateXOR(Size size) : base(size)
        {
        }

        public GateXOR(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
