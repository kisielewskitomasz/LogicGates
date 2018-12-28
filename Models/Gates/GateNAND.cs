using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNAND : Gate
    {
        protected override string FileName { get; set; } = "symbol_nand.png";

        public GateNAND() : base()
        {
        }

        public GateNAND(Size size) : base(size)
        {
        }

        public GateNAND(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
