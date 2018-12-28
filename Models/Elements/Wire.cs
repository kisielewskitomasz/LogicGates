using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Wire : Asset
    {
        protected override string FileName { get; set; } = "wire.png";

        public Wire() : base()
        {
        }

        public Wire(Size size) : base(size)
        {
        }

        public Wire(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}