using System;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public class Wire : Asset
    {
        public static int Thickness = 6;
        protected override string[] FileNames { get; set; } = { "element_wire_horizontal.png", "element_wire_vertical.png" };
        public override Size Size { get; protected set; }
        public Defs.Wire Type { get; protected set; }

        protected Connection ParentLine = null;
        public Wire(Connection parentLine, Defs.Wire wireType) : base()
        {
            ParentLine = parentLine;
            Type = wireType;
            CurrentTexture = (int)Type;
            if (Type == Defs.Wire.Horizontal)
                new Size(1, Wire.Thickness);
            else
                new Size(Wire.Thickness, 1);
        }

        public Wire(Size size, Connection parentLine, Defs.Wire wireType) : base(size)
        {
            ParentLine = parentLine;
            Type = wireType;
            CurrentTexture = (int)Type;
        }

        public Wire(Position position, Connection parentLine, Defs.Wire wireType) : base(position)
        {
            ParentLine = parentLine;
            Type = wireType;
            CurrentTexture = (int)Type;
        }

        public Wire(Size size, Position position, Connection parentLine, Defs.Wire wireType) : base(size, position)
        {
            ParentLine = parentLine;
            Type = wireType;
            CurrentTexture = (int)Type;
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