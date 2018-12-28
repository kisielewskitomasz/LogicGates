using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Lamp : Asset
    {
        public Lamp(string fileName) : base(fileName)
        {
        }

        public Lamp(string fileName, Size size) : base(fileName, size)
        {
        }

        public Lamp(string fileName, Size size, Position position) : base(fileName, size, position)
        {
        }

        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}