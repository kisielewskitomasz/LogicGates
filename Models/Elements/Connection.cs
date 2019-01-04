using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Connection
    {
        public List<Wire> WiresList = new List<Wire>();

        public Connection(Pin a, Pin b)
        {
            Position posA = a.Element.Position + a.Position;
            Position posB = b.Element.Position + b.Position;

            Position length = new Position(Math.Abs((posA - posB).Width), Math.Abs((posB - posA).Height));
            var hWire = new WireHorizontal(new Size(length.Width, 6), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
            var vWire = new WireVertical(new Size(6, length.Height), new Position(Math.Min(posA.Width, posB.Width) + length.Width, Math.Min(posA.Height, posB.Height)), this);
            WiresList.Add(hWire);
            WiresList.Add(vWire);
        }
    }
}