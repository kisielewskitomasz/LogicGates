using System;
using SDL2;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public class Background : Asset
    {
        public Background(string fileName) : base(fileName)
        {
        }

        public Background(string fileName, Size size) : base(fileName, size)
        {
        }

        public Background(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Render(IntPtr renderer)
        {

            var xTiles = Canvas.Width / Size.Width;
            var yTiles = Canvas.Height / Size.Heigth;
            int x, y;

            for(var i = 0; i < (xTiles * yTiles); i++)
            {
                x = (i % xTiles) * Size.Width;
                y = (i / xTiles) * Size.Heigth;

                Drawer.RenderTexture(Texture, renderer, x, y, Size.Width, Size.Heigth);
            }
        }
    }
}
