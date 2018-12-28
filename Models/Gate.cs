using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Gate : Asset
    {
        public Gate() : base()
        {
        }

        public Gate(Size size) : base(size)
        {
        }

        public Gate(Size size, Position position) : base(size, position)
        {
        }
    }
}