using System;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

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

        public override void Clicked(Position mousePosition, Input engineInput)
        {
        }

        public override void Render(IntPtr renderer)
        {
            Drawer.RenderTexture(Texture, renderer, 0, 0, Size.Width, Size.Height);
        }

        // for single tile
        // public override void Render(IntPtr renderer)
        // {

        //     var xTiles = Canvas.Width / Size.Width;
        //     var yTiles = Canvas.Height / Size.Height;
        //     int x, y;

        //     for(var i = 0; i < (xTiles * yTiles); i++)
        //     {
        //         x = (i % xTiles) * Size.Width;
        //         y = (i / xTiles) * Size.Height;

        //         Drawer.RenderTexture(Texture, renderer, x, y, Size.Width, Size.Height);
        //     }
        // }
    }
}
