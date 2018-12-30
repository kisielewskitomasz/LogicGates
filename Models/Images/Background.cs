using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Background : Asset
    {
        public override Size Size { get; protected set; } = new Size(Canvas.Width, Canvas.Height);
        protected override string FileName { get; set; } = "image_background.png";

        public Background() : base()
        {
        }

        public Background(Size size) : base(size)
        {
        }

        public Background(Position position) : base(position)
        {
        }

        public Background(Size size, Position position) : base(size, position)
        {
        }
    }
}
