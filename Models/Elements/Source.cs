using System;
using System.Collections.Generic;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public class Source : Element
    {
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(Dimensions.Element.Pin.Position.Out.Width, Dimensions.Element.Pin.Position.Out.Height, Defs.Pin.Out) };
        protected override string[] FileNames { get; set; } = { "element_logic0.png", "element_logic1.png" };

        public Source() : base()
        {
        }

        public Source(Size size, Defs.Element signal) : base(size)
        {
            CurrentTexture = (int)signal;
        }

        public Source(Position position, Defs.Element signal) : base(position)
        {
            CurrentTexture = (int)signal;
        }

        public Source(Size size, Position position, Defs.Element signal) : base(size, position)
        {
            CurrentTexture = (int)signal;
        }
    }
}