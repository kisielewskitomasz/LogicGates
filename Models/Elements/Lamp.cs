using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Lamp : Asset
    {
        public override Size Size { get; protected set; } = new Size {Width = 72, Height = 72};
        protected override string FileName { get; set; } = "lamp.png";

        public Lamp() : base()
        {
        }

        public Lamp(Size size) : base(size)
        {
        }

        public Lamp(Position position) : base(position)
        {
        }

        public Lamp(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}