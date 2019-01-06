using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateNOT object
    /// </summary>
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

        public override void ComputeOutput()
        {
            Defs.Connection outputState = Defs.Connection.Low;

            foreach (var pin in PinsList)
            {
                if (pin.Type == Defs.Pin.In)
                {
                    if (pin.ParentConnection.State != Defs.Connection.HighImpedance)
                        outputState |= pin.ParentConnection.State;
                    else
                        outputState = Defs.Connection.HighImpedance;
                }
                else
                {
                    if(outputState == Defs.Connection.High)
                        outputState = Defs.Connection.Low;
                    else if (outputState == Defs.Connection.Low)
                        outputState = Defs.Connection.High;
                    pin.ParentConnection.State = outputState;
                }
            }
        }
    }
}
