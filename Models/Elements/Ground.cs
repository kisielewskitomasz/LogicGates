using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Ground : Element
    {
        public override List<Pin> PinsList { get; protected set; } = new List<Pin>();
        protected override string FileName { get; set; } = "element_ground.png";

        public Ground() : base()
        {
        }

        public Ground(Size size) : base(size)
        {
        }

        public Ground(Position position) : base(position)
        {
        }

        public Ground(Size size, Position position) : base(size, position)
        {
        }
    }
}
