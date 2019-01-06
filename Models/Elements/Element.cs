using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Extend basic Asset as Element object
    /// </summary>
    public abstract class Element : Asset
    {
        public override Size Size { get; protected set; } = new Size(Dimensions.Element.Width, Dimensions.Element.Height);
        /// <summary>Keeps Element pins</summary>
        public abstract List<Pin> PinsList { get; protected set; }


        public Element() : base()
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }


        public Element(Size size) : base(size)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        public Element(Position position) : base(position)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        public Element(Size size, Position position) : base(size, position)
        {
            for(int i = 0; i < PinsList.Count; i++)
            {
                PinsList[i].Element = this;
            }
        }

        /// <summary>
        /// Check is Element in Tray
        /// </summary>
        /// <returns>True if Element is in Tray</returns>
        public bool IsInTray()
        {
            if (Position.Height > Dimensions.Tray.Height)
                return false;
            return true;
        }
    }
}