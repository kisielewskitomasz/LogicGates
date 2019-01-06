using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    /// <summary>
    /// Defines Connection object
    /// </summary>
    public class Connection
    {
        /// <summary>Keeps Connection wires</summary>
        public List<Wire> WiresList = new List<Wire>();
        /// <summary>Keeps first Pin of current connection</summary>
        public Pin PinA { get; set; } = null;
        /// <summary>Keeps second Pin of current connection</summary>
        public Pin PinB { get; set; } = null;
        /// <summary>Keeps current state of connection</summary>
        public Defs.Connection State { get; set; } = Defs.Connection.HighImpedance;

        /// <summary>
        /// Construct Connection with Pin A and Pin B
        /// </summary>
        /// <param name="a">First Pin of Connection</param>
        /// <param name="b">Second Pin of Connection</param>
        public Connection(Pin a, Pin b)
        {
            PinA = a;
            PinB = b;
            PinA.isConnected = true;
            PinB.isConnected = true;
            PinA.Element.IsMovable = false;
            PinB.Element.IsMovable = false;
            PinA.ParentConnection = this;
            PinB.ParentConnection = this;

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
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Max(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                    vWire = new Wire(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Vertical);
                }
                else if (direction.Height < 0)
                {
                    System.Console.WriteLine(">--- 2 ---<");
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                    vWire = new Wire(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Vertical);
                }
                else
                {
                    System.Console.WriteLine(">--- 6 ---<");
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                }
            }
            else if (direction.Width < 0)
            {
                if (direction.Height > 0)
                {
                    System.Console.WriteLine(">--- 3 ---<");
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Max(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                    vWire = new Wire(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Max(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Vertical);
                }
                else if (direction.Height < 0)
                {
                    System.Console.WriteLine(">--- 4 ---<");
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                    vWire = new Wire(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Max(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Vertical);
                }
                else
                {
                    System.Console.WriteLine(">--- 5 ---<");
                    hWire = new Wire(new Size(length.Width + Wire.Thickness, Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Horizontal);
                }
            }
            else
            {
                System.Console.WriteLine(">--- 7 ---<");
                vWire = new Wire(new Size(Wire.Thickness, length.Height + Wire.Thickness), new Position(Math.Min(posA.Width, posB.Width), Math.Min(posA.Height, posB.Height)), this, Defs.Wire.Vertical);
            }

            if(hWire != null)
                WiresList.Add(hWire);
            if(vWire != null)
                WiresList.Add(vWire);
        }

        /// <summary>
        /// Check is Connection connects something with Gate output Pin
        /// </summary>
        /// <returns>True if Connection connects something with Gate output Pin</returns>
        public bool isConnectedWithGateOutput()
        {
            if (((PinA.Element is Gate) && (PinA.Type == Defs.Pin.Out)) || ((PinB.Element is Gate) && (PinB.Type == Defs.Pin.Out)))
                return true;
            return false;
        }
    }
}