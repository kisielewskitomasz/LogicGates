using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Element : Asset
    {
        public override Size Size { get; protected set; } = new Size(72, 72);
        public override List<Position> InputPositionList { get; protected set; } = new List<Position>{new Position(8, 33)};
        public override List<Position> OutputPositionList { get; protected set; } = new List<Position>{};

        public Element() : base()
        {
        }

        public Element(Size size) : base(size)
        {
        }

        public Element(Position position) : base(position)
        {
        }

        public Element(Size size, Position position) : base(size, position)
        {
        }
    }
}