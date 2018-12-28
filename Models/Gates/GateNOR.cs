using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateNOR : Gate
    {
        public GateNOR(string fileName) : base(fileName)
        {
        }

        public GateNOR(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateNOR(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
        }
    }
}
