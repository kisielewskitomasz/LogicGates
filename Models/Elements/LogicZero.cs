using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LogicZero : Logic
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_logic0.png";

        public LogicZero()
        {
        }

        public LogicZero(Size size) : base(size)
        {
        }

        public LogicZero(Position position) : base(position)
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