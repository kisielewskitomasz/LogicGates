using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateXNOR object
    /// </summary>
    public class GateXNOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_xnor.png" };

        public GateXNOR() : base()
        {
        }

        public GateXNOR(Size size) : base(size)
        {
        }

        public GateXNOR(Position position) : base(position)
        {
        }

        public GateXNOR(Size size, Position position) : base(size, position)
        {
        }

        public override void ComputeOutput()
        {
            Defs.Connection outputState = Defs.Connection.HighImpedance;

            foreach (var pin in PinsList)
            {
                if (pin.Type == Defs.Pin.In)
                {
                    if (pin.ParentConnection.State != Defs.Connection.HighImpedance)
                    {
                        if (outputState == Defs.Connection.HighImpedance)
                        {
                            outputState = pin.ParentConnection.State;
                        }
                        else
                        {
                            outputState ^= pin.ParentConnection.State;
                        }
                    }
                    else
                        outputState = Defs.Connection.HighImpedance;
                }
            }

            if (outputState == Defs.Connection.High)
                outputState = Defs.Connection.Low;
            else if (outputState == Defs.Connection.Low)
                outputState = Defs.Connection.High;

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
