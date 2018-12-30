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
            var splashSize = new Size(384, 384);
            var splashPosition = new Position((Canvas.Width / 2) - (splashSize.Width / 2), (Canvas.Height / 2) - (splashSize.Height / 2));
            AsstesList.Add(new Images.Splash(splashSize, splashPosition));
        }
    }
}