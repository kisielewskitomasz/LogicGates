using System;
using System.IO;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    /// <summary>
    /// Extend basic Asset as Completed object
    /// </summary>
    public class Completed : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Banner.Width, Dimensions.Banner.Height);
        protected override string[] FileNames { get; set; } = { "image_completed.png" };

        public Completed(string fileName) : base()
        {
        }

        public Completed(Size size) : base(size)
        {
        }

        public Completed(Position position) : base(position)
        {
        }

        public Completed(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            Position relativeMenuMousePosition = relativeMousePosition - new Position(Dimensions.Banner.Space.Width, Dimensions.Banner.Space.Height);
            System.Console.WriteLine(relativeMenuMousePosition.Height);
            if ((relativeMenuMousePosition.Width >= 0) && (relativeMenuMousePosition.Width <= Dimensions.Banner.Button.Width))
            {
                if ((relativeMenuMousePosition.Height >= Dimensions.Banner.Button.Height * 4) && (relativeMenuMousePosition.Height <= (Dimensions.Banner.Button.Height * 5)))
                    Next();
            }
        }

        void Next()
        {
            Harness.GameCurrentLevel.AsstesList.Remove(this);
            Harness.NextLevel();
            Harness.RefreshOutput();
        }
    }
}