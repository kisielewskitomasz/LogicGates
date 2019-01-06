using System;
using System.IO;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Retry : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Banner.Width, Dimensions.Banner.Height);
        protected override string[] FileNames { get; set; } = { "image_retry.png" };

        public Retry(string fileName) : base()
        {
        }

        public Retry(Size size) : base(size)
        {
        }

        public Retry(Position position) : base(position)
        {
        }

        public Retry(Size size, Position position) : base(size, position)
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
            Harness.GameCurrentLevel.AsstesList.Remove(this);
            Harness.RefreshOutput();
        }
    }
}