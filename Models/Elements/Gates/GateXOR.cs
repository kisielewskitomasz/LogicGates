using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateXOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_xor.png" };

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
    }
}
