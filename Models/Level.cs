using System;
using System.Collections.Generic;
namespace LogicGates.Models
{
    public abstract class Level
    {
        public List<Object> Objects { get; private set; } = null;

        public Level()
        {
            Objects = new List<Object>();
        }
    }
}