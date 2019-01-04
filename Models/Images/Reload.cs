using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Reload : Asset
    {
        public override Size Size { get; protected set; } = new Size(72, 72);
        protected override string FileName { get; set; } = "image_reload.png";

        public Reload() : base()
        {
        }

        public Reload(Size size) : base(size)
        {
        }

        public Reload(Position position) : base(position)
        {
        }

        public Reload(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            Harness.ReloadLevel();
        }

    }
}