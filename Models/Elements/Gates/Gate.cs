using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Defines basic Gate object
    /// </summary>
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

        public override void ClickedRight(Position mousePosition, Position relativeMousePosition)
        {
        }

        /// <summary>
        /// Compute Gate output based on input signals
        /// </summary>
        public abstract void ComputeOutput();

        /// <summary>
        /// Sets computed output Signal
        /// </summary>
        /// <param name="outputState">Singal to set</param>
        protected void SetOutput(Defs.Connection outputState)
        {
            foreach (var pin in PinsList)
            {
                if (pin.Type == Defs.Pin.Out)
                {
                    pin.ParentConnection.State = outputState;
                    foreach (var wire in pin.ParentConnection.WiresList)
                    {
                        wire.CurrentTexture = (int)wire.Type + (2 * ((int)pin.ParentConnection.State + 1));
                        Engine.Harness.RefreshOutput();
                    }
                }
            }
        }

        /// <summary>
        /// Negates output Signal
        /// </summary>
        /// <param name="outputState">Signal to negate</param>
        protected Defs.Connection NegateOutput(Defs.Connection outputState)
        {
            if (outputState == Defs.Connection.High)
                return outputState = Defs.Connection.Low;
            else if (outputState == Defs.Connection.Low)
                return outputState = Defs.Connection.High;
            return Defs.Connection.HighImpedance;
        }
    }
}