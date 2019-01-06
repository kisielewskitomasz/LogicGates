using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Gate as GateNAND object
    /// </summary>
    public class GateNAND : Gate
    {
        protected override string[] FileNames { get; set; } = { "gate_nand.png" };

        public GateNAND() : base()
        {
        }

        public GateNAND(Size size) : base(size)
        {
        }

        public GateNAND(Position position) : base(position)
        {
        }

        public GateNAND(Size size, Position position) : base(size, position)
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

            SetOutput(NegateOutput(outputState));
        }
    }
}
