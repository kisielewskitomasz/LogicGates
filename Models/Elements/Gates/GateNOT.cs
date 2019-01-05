using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateNOT : Gate
    {
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 33, Defs.Pin.In), new Pin(66, 33, Defs.Pin.Out) };
        protected override string[] FileNames { get; set; } = { "gate_not.png" };

        public GateNOT() : base()
        {
        }

        public GateNOT(Size size) : base(size)
        {
        }

        public GateNOT(Position position) : base(position)
        {
        }

        public GateNOT(Size size, Position position) : base(size, position)
        {
        }
    }
}
