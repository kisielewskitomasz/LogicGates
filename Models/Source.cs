using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Source : Asset
    {
        public Source(string fileName) : base(fileName)
        {
        }

        public Source(string fileName, Size size) : base(fileName, size)
        {
        }

        public Source(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}