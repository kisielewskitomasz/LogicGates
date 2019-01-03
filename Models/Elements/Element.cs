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
        public override List<Position> InputPositionsList { get; protected set; } = new List<Position> { new Position(0, 33) };
        public override List<Position> OutputPositionsList { get; protected set; } = new List<Position> { new Position(64, 33) };

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

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            foreach (var inputPosition in InputPositionsList)
            {
                if ((relativeMousePosition.Width >= inputPosition.Width) && (relativeMousePosition.Width <= (inputPosition.Width + 8)) &&
                    (relativeMousePosition.Height >= inputPosition.Height) && (relativeMousePosition.Height <= (inputPosition.Height + 6)))
                {
                    System.Console.WriteLine($"Left click at: {relativeMousePosition.Width}, {relativeMousePosition.Height} on: {this.ToString()} - input: {inputPosition.ToString()}");
                    // TODO: put here code for click on input
                    break;
                }
            }

            foreach (var outputPosition in OutputPositionsList)
            {
                if ((relativeMousePosition.Width >= outputPosition.Width) && (relativeMousePosition.Width <= (outputPosition.Width + 8)) &&
                    (relativeMousePosition.Height >= outputPosition.Height) && (relativeMousePosition.Height <= (outputPosition.Height + 6)))
                {
                    System.Console.WriteLine($"Left click at: {relativeMousePosition.Width}, {relativeMousePosition.Height} on: {this.ToString()} - output: {outputPosition.ToString()}");
                    // TODO: put here code for click on output
                    break;
                }
            }
        }
    }
}