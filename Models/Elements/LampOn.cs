using System;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LampOn : Lamp
    {
        protected override string FileName { get; set; } = "element_lamp_on.png";
        protected override string FileNameAlt { get; set; } = "element_lamp_off.png";

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

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            //ChangeState();
        }
    }
}