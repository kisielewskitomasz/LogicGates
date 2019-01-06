using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateOR object
    /// </summary>
    public class GateOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_or.png" };

        public GateOR() : base()
        {
        }

        public GateOR(Size size) : base(size)
        {
        }

        public GateOR(Position position) : base(position)
        {
        }

        public GateOR(Size size, Position position) : base(size, position)
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
            }

            SetOutput(outputState);
        }
    }
}
