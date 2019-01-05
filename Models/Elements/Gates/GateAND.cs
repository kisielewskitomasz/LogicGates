using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateAND : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_and.png" };

        public GateAND() : base()
        {
        }

        public GateAND(Size size) : base(size)
        {
        }

        public GateAND(Position position) : base(position)
        {

        }

        public GateAND(Size size, Position position) : base(size, position)
        {
        }
    }
}
