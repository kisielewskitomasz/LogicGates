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

        public override void Render(IntPtr renderer)
        {
            Drawer.RenderTexture(Texture, renderer, Position.Width, Position.Height, Size.Width, Size.Height);
        }
    }
}