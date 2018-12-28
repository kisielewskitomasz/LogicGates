using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXOR : Gate
    {
        public GateXOR(string fileName) : base(fileName)
        {
        }

        public GateXOR(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateXOR(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
