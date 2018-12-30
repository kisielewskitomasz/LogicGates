using System;
using System.IO;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Splash : Asset
    {
        public override Size Size { get; protected set; } = new Size(384, 384);
        protected override string FileName { get; set; } = "image_splash.png";

        public Splash(string fileName) : base()
        {
        }

        public Splash(Size size) : base(size)
        {
        }

        public Splash(Position position) : base(position)
        {
        }

        public Splash(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition)
        {
            if ((mousePosition.Width >= (Position.Width + 32)) && (mousePosition.Width <= (Position.Width + Size.Width - 32)))
            {
                if ((mousePosition.Height >= Position.Height + 32 + (64 * 4)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 5))))
                    Back();
            }
        }

        void Back()
        {
            Harness.GameCurrentLevel = new Level00();
            Harness.RefreshOutput();
        }
    }
}