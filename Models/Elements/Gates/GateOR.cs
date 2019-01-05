using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_or.png" };

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
    }
}
