using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Element : Asset
    {
        public override Size Size { get; protected set; } = new Size(72, 72);
        public virtual int State { get; protected set; } = -1;
        public virtual List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 33, IO.In) };

        public Element() : base()
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        public Element(Size size) : base(size)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        public Element(Position position) : base(position)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        public Element(Size size, Position position) : base(size, position)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }
    }
}