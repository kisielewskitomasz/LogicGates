using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public class Lamp : Element
    {
        protected override string[] FileNames { get; set; } = { "element_lamp_off.png", "element_lamp_on.png" };
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 33, Defs.Pin.In), new Pin(66, 33, Defs.Pin.Out) };
        public Lamp() : base()
        {
        }

        public Lamp(Size size, Defs.Element signal) : base(size)
        {
            CurrentTexture = (int)signal;
        }

        public Lamp(Position position, Defs.Element signal) : base(position)
        {
            CurrentTexture = (int)signal;
        }

        public Lamp(Size size, Position position, Defs.Element signal) : base(size, position)
        {
            CurrentTexture = (int)signal;
        }
    }
}