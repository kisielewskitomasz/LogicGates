using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    /// <summary>
    /// Extend basic Asset as Simulate object
    /// </summary>
    public class Simulate : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Element.Width, Dimensions.Element.Width);
        protected override string[] FileNames { get; set; } = { "image_start.png" };

        public Simulate() : base()
        {
        }

        public Simulate(Size size) : base(size)
        {
        }

        public Simulate(Position position) : base(position)
        {
        }

        public Simulate(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            Harness.SimulateLevel();
        }

    }
}