using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Gate : Element
    {
        public override bool IsMovable { get; set; } = true;
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 20, Defs.Pin.In), new Pin(0, 46, Defs.Pin.In), new Pin(66, 33, Defs.Pin.Out)  };

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