using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Gate : Asset
    {
        public Gate(string fileName) : base(fileName)
        {
        }

        public Gate(string fileName, Size size) : base(fileName, size)
        {
        }

        public Gate(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }
    }
}