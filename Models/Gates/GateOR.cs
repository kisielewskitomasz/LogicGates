using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateOR : Gate
    {
        protected override string FileName { get; set; } = "symbol_or.png";

        public GateOR() : base()
        {
        }

        public GateOR(Size size) : base(size)
        {
        }

        public GateOR(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
