using System;
using System.Collections.Generic;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Level00 : Level
    {
        public Level00()
        {
            AsstesList.Add(new Background("background.png", new Size {Width = 16, Height = 16}));

            var menuSize = new Size {
                Width = 200,
                Height = 200
            };
            var menuPosition = new Position {
                Width = (Canvas.Width / 2) - (menuSize.Width / 2),
                Height = (Canvas.Height / 2) - (menuSize.Height / 2)
            };
            AsstesList.Add(new Menu("tile_pcb.png", menuSize, menuPosition));
        }
    }
}