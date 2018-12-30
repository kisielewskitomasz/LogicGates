using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOR : Gate
    {
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
    }
}
