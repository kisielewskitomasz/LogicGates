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
            AsstesList.Add(new Images.Finished(new Size(Dimensions.Banner.Width, Dimensions.Banner.Height), new Position((Dimensions.Canvas.Width / 2) - (Dimensions.Banner.Width / 2), (Dimensions.Canvas.Height / 2) - (Dimensions.Banner.Height / 2))));
        }
    }
}