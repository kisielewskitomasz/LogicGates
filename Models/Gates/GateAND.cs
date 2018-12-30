using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateAND : Gate
    {
        protected override string FileName { get; set; } = "gate_and.png";

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
