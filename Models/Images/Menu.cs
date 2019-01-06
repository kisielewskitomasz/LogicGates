using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    /// <summary>
    /// Extend basic Asset as Menu object
    /// </summary>
    public class Menu : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Banner.Width, Dimensions.Banner.Height);

        protected override string[] FileNames { get; set; } = { "image_menu.png" };

        public Menu() : base()
        {
        }

        public Menu(Size size) : base(size)
        {
        }

        public Menu(Position position) : base(position)
        {
        }

        public Menu(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            Position relativeMenuMousePosition = relativeMousePosition - new Position(Dimensions.Banner.Space.Width, Dimensions.Banner.Space.Height);
            if ((relativeMenuMousePosition.Width >= 0) && (relativeMenuMousePosition.Width <= Dimensions.Banner.Button.Width))
            {
                if ((relativeMenuMousePosition.Height >= Dimensions.Banner.Button.Height * 0) && (relativeMenuMousePosition.Height <= (Dimensions.Banner.Button.Height * 1)))
                    ContiuneButton();
                else if ((relativeMenuMousePosition.Height >= Dimensions.Banner.Button.Height * 2) && (relativeMenuMousePosition.Height <= (Dimensions.Banner.Button.Height * 3)))
                    ResetButton();
                else if ((relativeMenuMousePosition.Height >= Dimensions.Banner.Button.Height * 4) && (relativeMenuMousePosition.Height <= (Dimensions.Banner.Button.Height * 5)))
                    QuitButton();
            }
        }

        void ContiuneButton()
        {
            if(!(Harness.GameCurrentLevel is Level00))
            {
                Harness.GameCurrentLevel.AsstesList.Remove(this);
                Harness.RefreshOutput();
            }
            else
                Harness.LoadGame();
        }

        void ResetButton() =>
            Harness.ResetGame();

        void QuitButton() =>
            Harness.QuitGame();
    }
}