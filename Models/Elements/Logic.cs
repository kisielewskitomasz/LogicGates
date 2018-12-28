using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Logic : Asset
    {
        public Logic() : base()
        {
        }

        public Logic(Size size) : base(size)
        {
        }

        public Logic(Position position) : base(position)
        {
        }

        public Logic(Size size, Position position) : base(size, position)
        {
        }
    }
}