using System;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Asset as Wire object
    /// </summary>
    public class Wire : Asset
    {
        /// <summary>Keeps Wire thickness</summary>
        public static int Thickness = Dimensions.Wire.Thickness;
        protected override string[] FileNames { get; set; } = { "element_wire_horizontal.png", "element_wire_vertical.png" };
        public override Size Size { get; protected set; }
        /// <summary>Keeps Wire type</summary>
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

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            System.Console.WriteLine($"Set connection state to: {ParentLine.State}");
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

            Harness.GameCurrentLevel.ConnectionsList.Remove(ParentLine);

            bool unlockA = true;
            bool unlockB = true;
            foreach(var pin in ParentLine.PinA.Element.PinsList)
            {
                if (pin.isConnected == true)
                    unlockA = false;
            }

            foreach(var pin in ParentLine.PinB.Element.PinsList)
            {
                if (pin.isConnected == true)
                    unlockB = false;
            }

            if (unlockA)
                ParentLine.PinA.Element.IsMovable = true;

            if (unlockB)
                ParentLine.PinB.Element.IsMovable = true;
        }
    }
}