using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateAND : Gate
    {
        public GateAND(string fileName) : base(fileName)
        {
        }

        public GateAND(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateAND(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
