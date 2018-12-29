using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LogicOne : Logic
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_logic1.png";

        public LogicOne()
        {
        }

        public LogicOne(Size size) : base(size)
        {
        }

        public LogicOne(Position position) : base(position)
        {
        }

        public LogicOne(Size size, Position position) : base(size, position)
        {
        }
        public override void Clicked(Position mousePosition)
        {
        }
    }
}