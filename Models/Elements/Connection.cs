using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class Connection
    {
        public List<Wire> WiresList = new List<Wire>();
        public Pin PinA { get; set; } = null;
        public Pin PinB { get; set; } = null;
        public CS ConnectionState { get; set; } = CS.HighImpedance;

        public Connection(Pin a, Pin b)
        {
            PinA = a;
            PinB = b;
            PinA.isConnected = true;
            PinB.isConnected = true;
            PinA.Element.IsMovable = false;
            PinB.Element.IsMovable = false;
            PinA.ParentConnection = this;

            Position posA = PinA.Element.Position + PinA.Position;
            Position posB = PinB.Element.Position + PinB.Position;

            Position direction = posB - posA;
            Position length = new Position(Math.Abs((posA - posB).Width), Math.Abs((posB - posA).Height));
            Wire vWire = null;
            Wire hWire = null;

            if (direction.Width > 0)
            {
                if (direction.Height > 0)
                {
                    System.Console.WriteLine(">--- 1 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Max(posA.Height, posB.Height)), this);
                    vWire = new WireVertical(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
                else if (direction.Height < 0)
                {
                    System.Console.WriteLine(">--- 2 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                    vWire = new WireVertical(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
                else
                {
                    System.Console.WriteLine(">--- 6 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
            }
            else if (direction.Width < 0)
            {
                if (direction.Height > 0)
                {
                    System.Console.WriteLine(">--- 3 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Max(posA.Height, posB.Height)), this);
                    vWire = new WireVertical(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Max(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
                else if (direction.Height < 0)
                {
                    System.Console.WriteLine(">--- 4 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                    vWire = new WireVertical(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Max(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
                else
                {
                    System.Console.WriteLine(">--- 5 ---<");
                    hWire = new WireHorizontal(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
                }
            }
            else
            {
                System.Console.WriteLine(">--- 7 ---<");
                vWire = new WireVertical(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this);
            }

            if(hWire != null)
                WiresList.Add(hWire);
            if(vWire != null)
                WiresList.Add(vWire);
        }
    }
}