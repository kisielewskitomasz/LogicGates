using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public abstract class Wire : Element
    {
        protected Connection ParentLine = null;
        public Wire(Connection parentLine) : base()
        {
            ParentLine = parentLine;
        }

        public Wire(Size size, Connection parentLine) : base(size)
        {
            ParentLine = parentLine;
        }

        public Wire(Position position, Connection parentLine) : base(position)
        {
            ParentLine = parentLine;
        }

        public Wire(Size size, Position position, Connection parentLine) : base(size, position)
        {
            ParentLine = parentLine;
        }
    }
}