using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Wire : Asset
    {
        public Wire(string fileName) : base(fileName)
        {
        }

        public Wire(string fileName, Size size) : base(fileName, size)
        {
        }

        public Wire(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}