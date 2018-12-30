using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Images
{
    public class Menu : Asset
    {
        public override Size Size { get; protected set; } = new Size { Width = 384, Height = 384 };
        protected override string FileName { get; set; } = "image_menu.png";

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

        public override void Clicked(Position mousePosition)
        {
            if ((mousePosition.Width >= (Position.Width + 32)) && (mousePosition.Width <= (Position.Width + Size.Width - 32)))
            {
                if ((mousePosition.Height >= Position.Height + 32) && (mousePosition.Height <= (Position.Height + 32 + (64 * 1))))
                    ContiuneButton();
                else if ((mousePosition.Height >= Position.Height + 32 + (64 * 2)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 3))))
                    ResetButton();
                else if ((mousePosition.Height >= Position.Height + 32 + (64 * 4)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 5))))
                    QuitButton();
            }
        }

        void ContiuneButton() =>
            Harness.LoadGame();

        void ResetButton() =>
            Harness.ResetGame();

        void QuitButton() =>
            Harness.QuitGame();
    }
}