using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Simulate : Asset
    {
        public override Size Size { get; protected set; } = new Size(72, 72);
        protected override string FileName { get; set; } = "image_start.png";

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