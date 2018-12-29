using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LampOn : Lamp
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "element_lamp_on.png";

        public LampOn() : base()
        {
        }

        public LampOn(Size size) : base(size)
        {
        }

        public LampOn(Position position) : base(position)
        {
        }

        public LampOn(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}