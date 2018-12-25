using System;
using System.Collections.Generic;

namespace LogicGates.Models
{
    public class Level00 : Level
    {
        public Level00()
        {
            AsstesList.Add(new Background("background.png", new Size {Width = 16, Heigth = 16}));
        }
    }
}