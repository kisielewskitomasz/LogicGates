using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Line
    {
        List<Wire> WiresList = new List<Wire>();

        public Line()
        {
            WiresList.Add(new WireHorizontal(this));
            WiresList.Add(new WireVertical(this));
        }
    }
}