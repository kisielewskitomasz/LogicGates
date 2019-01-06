using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateNOR object
    /// </summary>
    public class GateNOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_nor.png" };

        public GateNOR() : base()
        {
        }

        public GateNOR(Size size) : base(size)
        {
        }

        public GateNOR(Position position) : base(position)
        {
        }

        public GateNOR(Size size, Position position) : base(size, position)
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

            SetOutput(NegateOutput(outputState));
        }
    }
}
