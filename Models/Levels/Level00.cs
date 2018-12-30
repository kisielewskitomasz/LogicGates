using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public class Level00 : Level
    {
        public Level00()
        {
            var menuSize = new Size(384, 384);
            var menuPosition = new Position((Canvas.Width / 2) - (menuSize.Width / 2), (Canvas.Height / 2) - (menuSize.Height / 2));
            AsstesList.Add(new Images.Menu(menuSize, menuPosition));
        }
    }
}