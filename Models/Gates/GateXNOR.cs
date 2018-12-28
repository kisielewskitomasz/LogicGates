using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateXNOR : Gate
    {
        public GateXNOR(string fileName) : base(fileName)
        {
        }

        public GateXNOR(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateXNOR(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}
