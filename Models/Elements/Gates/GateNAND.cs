using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateNAND : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_nand.png" };

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
    }
}
