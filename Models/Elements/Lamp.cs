using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Lamp : Asset
    {
        protected override string FileName { get; set; } = "lamp.png";

        public Lamp() : base()
        {
        }

        public Lamp(Size size) : base(size)
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