using System;
using System.Collections.Generic;

namespace LogicGates.Models
{
    public abstract class Level
    {
        public List<Asset> AsstesList { get; private set; } = null;

        public Level()
        {
            AsstesList = new List<Asset>();
        }
    }
}