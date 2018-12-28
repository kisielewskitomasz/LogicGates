using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOT : Gate
    {
        protected override string FileName { get; set; } = "symbol_not.png";

        public GateNOT() : base()
        {
        }

        public GateNOT(Size size) : base(size)
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
