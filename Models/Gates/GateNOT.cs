using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOT : Gate
    {
        public GateNOT(string fileName) : base(fileName)
        {
        }

        public GateNOT(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateNOT(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
