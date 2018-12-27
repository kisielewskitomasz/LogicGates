using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Menu : Asset
    {
        public Menu(string fileName) : base(fileName)
        {
        }

        public Menu(string fileName, Size size) : base(fileName, size)
        {
        }

        public Menu(string fileName, Size size, Position position) : base(fileName, size, position)
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

        public override void Render() =>
            Drawer.RenderTexture(Texture, Output.Renderer, Position.Width, Position.Height, Size.Width, Size.Height);

        void ContiuneButton() =>
            Harness.LoadGame();

        void ResetButton() =>
            Harness.ResetGame();

        void QuitButton() =>
            Harness.QuitGame();
    }
}