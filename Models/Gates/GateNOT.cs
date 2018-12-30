using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOT : Gate
    {
        public override List<Position> InputPositionList { get; protected set; } = new List<Position>{new Position(8, 33)};
        protected override string FileName { get; set; } = "gate_not.png";

        public GateNOT() : base()
        {
        }

        public GateNOT(Size size) : base(size)
        {
        }

        public GateNOT(Position position) : base(position)
        {
        }

        public GateNOT(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
