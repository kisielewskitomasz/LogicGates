using System;
using System.Collections.Generic;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Logic : Element
    {
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(66, 33, IO.Out) };

        public Logic() : base()
        {
        }

        public Logic(Size size) : base(size)
        {
        }

        public Logic(Position position) : base(position)
        {
        }

        public Logic(Size size, Position position) : base(size, position)
        {
        }
    }
}