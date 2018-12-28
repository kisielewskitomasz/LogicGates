using System;
using LogicGates.Common;

namespace LogicGates.Models
{
    public class Source : Asset
    {
        protected override string FileName { get; set; } = "symbol_source.png";

        public Source()
        {
        }

        public Source(Size size) : base(size)
        {
        }

        public Source(Size size, Position position) : base(size, position)
        {
        }
        public override void Clicked(Position mousePosition)
        {
            throw new NotImplementedException();
        }
    }
}