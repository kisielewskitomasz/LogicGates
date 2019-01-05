using System;
using System.IO;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Splash : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Banner.Width, Dimensions.Banner.Height);
        protected override string[] FileNames { get; set; } = { "image_splash.png" };

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

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            Position relativeMenuMousePosition = relativeMousePosition - new Position(Dimensions.Banner.Space.Width, Dimensions.Banner.Space.Height);
            System.Console.WriteLine(relativeMenuMousePosition.Height);
            if ((relativeMenuMousePosition.Width >= 0) && (relativeMenuMousePosition.Width <= Dimensions.Banner.Button.Width))
            {
                if ((relativeMenuMousePosition.Height >= Dimensions.Banner.Button.Height * 4) && (relativeMenuMousePosition.Height <= (Dimensions.Banner.Button.Height * 5)))
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