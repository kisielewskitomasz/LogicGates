using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public class Level01 : Level
    {
        public Level01()
        {
            AsstesList.Add(new Tray("tray.png", new Size {Width = 1024, Height = 64}));
            Harness.SaveGame();
        }
    }
}
