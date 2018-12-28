using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LogicZero : Logic
    {
        protected override string FileName { get; set; } = "symbol_logic0.png";

        public LogicZero()
        {
        }

        public LogicZero(Size size) : base(size)
        {
        }

        public LogicZero(Size size, Position position) : base(size, position)
        {
        }
        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}