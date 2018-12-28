using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Ground : Asset
    {
        protected override string FileName { get; set; } = "ground.png";

        public Ground() : base()
        {
        }

        public Ground(Size size) : base(size)
        {
        }

        public Ground(Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}
