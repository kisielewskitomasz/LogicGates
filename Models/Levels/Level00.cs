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
            var menuSize = new Size {
                Width = 384,
                Height = 384
            };
            var menuPosition = new Position {
                Width = (Canvas.Width / 2) - (menuSize.Width / 2),
                Height = (Canvas.Height / 2) - (menuSize.Height / 2)
            };
            AsstesList.Add(new Menu("menu.png", menuSize, menuPosition));
        }
    }
}