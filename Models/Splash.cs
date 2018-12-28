using System;
using System.IO;
using SDL2;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Splash : Asset
    {
        public Splash(string fileName) : base(fileName)
        {
        }

        public Splash(string fileName, Size size) : base(fileName, size)
        {
        }

        public Splash(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            if ((mousePosition.Width >= (Position.Width + 32)) && (mousePosition.Width <= (Position.Width + Size.Width - 32)))
            {
                if((mousePosition.Height >= Position.Height + 32 + (64 * 4)) && (mousePosition.Height <= (Position.Height + 32 + (64 * 5))))
                    Back();
            }
        }

        void Back()
        {
            Harness.GameCurrentLevel = new Level00();
            Harness.RefreshOutput();
        }
    }
}