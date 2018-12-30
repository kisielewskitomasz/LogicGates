using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Gate : Asset
    {
        public override Size Size { get; protected set; } = new Size(72, 72);
        public override List<Position> InputPositionList { get; protected set; } = new List<Position> { new Position(8, 20), new Position(8, 46) };
        public override List<Position> OutputPositionList { get; protected set; } = new List<Position> { };

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
    }
}