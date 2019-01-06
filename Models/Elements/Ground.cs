using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Ground : Element
    {
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 33, Defs.Pin.In) };
        protected override string[] FileNames { get; set; } = { "element_ground.png" };

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
