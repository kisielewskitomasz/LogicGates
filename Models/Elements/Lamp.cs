using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Lamp : Element
    {
        public Lamp() : base()
        {
        }

        public Lamp(Size size) : base(size)
        {
        }

        public Lamp(Position position) : base(position)
        {
        }

        public Lamp(Size size, Position position) : base(size, position)
        {
        }
    }
}