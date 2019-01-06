using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    /// <summary>
    /// Extend basic Asset as Reload object
    /// </summary>
    public class Reload : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Element.Width, Dimensions.Element.Width);

        protected override string[] FileNames { get; set; } = { "image_reload.png" };

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