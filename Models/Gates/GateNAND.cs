using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNAND : Gate
    {
        public GateNAND(string fileName) : base(fileName)
        {
        }

        public GateNAND(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateNAND(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
