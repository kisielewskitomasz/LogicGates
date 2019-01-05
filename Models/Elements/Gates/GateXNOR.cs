using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateXNOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_xnor.png" };

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
    }
}
