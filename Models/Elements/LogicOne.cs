using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LogicOne : Logic
    {
        protected override string FileName { get; set; } = "symbol_logic1.png";

        public LogicOne()
        {
        }

        public LogicOne(Size size) : base(size)
        {
        }

        public LogicOne(Size size, Position position) : base(size, position)
        {
        }
        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}