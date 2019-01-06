using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateXOR object
    /// </summary>
    public class GateXOR : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_xor.png" };

        public GateXOR() : base()
        {
        }

        public GateXOR(Size size) : base(size)
        {
        }

        public GateXOR(Size size, Position position) : base(size, position)
        {
        }

        public GateXOR(Position position) : base(position)
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
