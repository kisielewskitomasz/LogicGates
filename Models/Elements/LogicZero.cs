using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LogicZero : Logic
    {
        protected override string FileName { get; set; } = "element_logic0.png";

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
    }
}