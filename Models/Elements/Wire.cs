using System;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Wire : Asset
    {
        public static int Thickness = 6;

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

        public override void ClickedRight(Position mousePosition, Position relativeMousePosition)
        {
            foreach(var wire in ParentLine.WiresList)
            {
                Harness.GameCurrentLevel.AsstesList.Remove(wire);
            }
            Harness.RefreshOutput();

            ParentLine.PinA.isConnected = false;
            ParentLine.PinB.isConnected = false;

            ParentLine.WiresList.Clear();

            foreach(var pin in ParentLine.PinA.Element.PinsList)
            {
                if (pin.isConnected == true)
                    return;
            }

            ParentLine.PinA.Element.IsMovable = true;
            ParentLine.PinB.Element.IsMovable = true;
        }
    }
}