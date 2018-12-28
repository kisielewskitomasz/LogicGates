using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class GateOR : Gate
    {
        public GateOR(string fileName) : base(fileName)
        {
        }

        public GateOR(string fileName, Size size) : base(fileName, size)
        {
        }

        public GateOR(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}
