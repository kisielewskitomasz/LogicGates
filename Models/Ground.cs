using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Ground : Asset
    {
        public Ground(string fileName) : base(fileName)
        {
        }

        public Ground(string fileName, Size size) : base(fileName, size)
        {
        }

        public Ground(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}
