using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LampOff : Lamp
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "symbol_lamp_off.png";

        public LampOff() : base()
        {
        }

        public LampOff(Size size) : base(size)
        {
        }

        public LampOff(Position position) : base(position)
        {
        }

        public LampOff(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}