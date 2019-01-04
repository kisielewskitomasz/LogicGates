using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{

    public abstract class Asset
    {
        protected abstract string FileName { get; set; }
        public IntPtr Texture { get; protected set; } = IntPtr.Zero;
        public virtual bool IsMovable { get; protected set; } = false;
        public abstract Size Size { get; protected set; }
        public Position Position = new Position();

        public Asset()
        {
            Texture = Loader.LoadTextureFromImage(FileName, Output.Renderer);

            if (Texture == IntPtr.Zero)
            {
                Logger.Fatal(nameof(Loader.LoadTextureFromImage),
                    () => Output.ReleaseAndQuit(Output.Window, Output.Renderer, IntPtr.Zero, Texture));
            }
        }

        public Asset(Size size) : this()
        {
            Size = size;
        }

        public Asset(Position position) : this()
        {
            Position = position;
        }

        public Asset(Size size, Position position) : this()
        {
            Size = size;
            Position = position;
        }
        public virtual void Render() =>
            Drawer.RenderTexture(Texture, Output.Renderer, Position.Width, Position.Height, Size.Width, Size.Height);

        public virtual void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {

        }

        public virtual void ClickedLeftOnInput(Position mousePosition, Position relativeMousePosition)
        {

        }
        public virtual void ClickedLeftOnOutput(Position mousePosition, Position relativeMousePosition)
        {

        }

        public virtual void ClickedRight(Position mousePosition, Position relativeMousePosition)
        {

        }

        public virtual void ClickedRightOnInput(Position mousePosition, Position relativeMousePosition)
        {

        }

        public virtual void ClickedRightOnOutput(Position mousePosition, Position relativeMousePosition)
        {

        }
    }
}