using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Gate : Element
    {
        public override bool IsMovable { get; protected set; } = true;
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 20, IO.In), new Pin(0, 46, IO.In), new Pin(64, 33, IO.Out)  };

        public Gate() : base()
        {
        }

        public Gate(Size size) : base(size)
        {
        }

        public Gate(Position position) : base(position)
        {
        }

        public Gate(Size size, Position position) : base(size, position)
        {
        }
    }
}