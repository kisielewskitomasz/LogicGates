using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class GateAND : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_and.png" };

        public GateAND() : base()
        {
        }

        public GateAND(Size size) : base(size)
        {
        }

        public GateAND(Position position) : base(position)
        {

        }

        public GateAND(Size size, Position position) : base(size, position)
        {
        }

        public override void ComputeOutput()
        {
            Defs.Connection outputState = Defs.Connection.High;

            foreach (var pin in PinsList)
            {
                if (pin.Type == Defs.Pin.In)
                {
                    if (pin.ParentConnection.State != Defs.Connection.HighImpedance)
                        outputState &= pin.ParentConnection.State;
                    else
                        outputState = Defs.Connection.HighImpedance;
                }
            }

            foreach (var pin in PinsList)
            {
                if (pin.Type == Defs.Pin.Out)
                {
                    pin.ParentConnection.State = outputState;
                }
            }
        }
    }
}
