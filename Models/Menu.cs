using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Menu : Asset
    {
        protected override string FileName { get; set; } = "menu.png";

        public Menu(string fileName) : base()
        {
        }

        public Menu(string fileName, Size size) : base(size)
        {
        }

        public Menu(string fileName, Size size, Position position) : base(size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            if ((mousePosition.Width >= (Position.Width + 32)) && (mousePosition.Width <= (Position.Width + Size.Width - 32)))
            {
                if((mousePosition.Height >= Position.Height + 32) && (mousePosition.Height <= (Position.Height + 32 + (64 * 1))))
                    ContiuneButton();
                else if((mousePosition.Height >= Position.Height + 32 + (64 * 2)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 3))))
                    ResetButton();
                else if((mousePosition.Height >= Position.Height + 32 + (64 * 4)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 5))))
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