using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public class Level99 : Level
    {
        public Level99()
        {
            var splashSize = new Size {
                Width = 384,
                Height = 384
            };
            var splashPosition = new Position {
                Width = (Canvas.Width / 2) - (splashSize.Width / 2),
                Height = (Canvas.Height / 2) - (splashSize.Height / 2)
            };
            AsstesList.Add(new Splash(splashSize, splashPosition));
        }
    }
}