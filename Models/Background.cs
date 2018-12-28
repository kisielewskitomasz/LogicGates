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

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
