using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    /// <summary>
    /// Extends Level as Level00
    /// </summary>
    public class Level00 : Level
    {
        public Level00()
        {
            AsstesList.Add(new Images.Menu(new Size(Dimensions.Banner.Width, Dimensions.Banner.Height), new Position((Dimensions.Canvas.Width / 2) - (Dimensions.Banner.Width / 2), (Dimensions.Canvas.Height / 2) - (Dimensions.Banner.Height / 2))));
        }
    }
}