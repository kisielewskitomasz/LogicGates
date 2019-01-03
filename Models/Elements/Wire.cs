using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public abstract class Wire : Element
    {
        protected Line ParentLine = null;
        public Wire(Line parentLine) : base()
        {
            ParentLine = parentLine;
        }

        public Wire(Size size, Line parentLine) : base(size)
        {
            ParentLine = parentLine;
        }

        public Wire(Position position, Line parentLine) : base(position)
        {
            ParentLine = parentLine;
        }

        public Wire(Size size, Position position, Line parentLine) : base(size, position)
        {
            ParentLine = parentLine;
        }
    }
}