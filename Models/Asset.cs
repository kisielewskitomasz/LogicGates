using System;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{

    public abstract class Asset
    {
        public IntPtr Texture { get; protected set; } = IntPtr.Zero;
        public Size Size;
        public Position Position;

        protected abstract string FileName { get; set; }

        public Asset()
        {
            Texture = Loader.LoadTextureFromImage(FileName, Output.Renderer);

            if(Texture == IntPtr.Zero)
            {
                Logger.Fatal(nameof(Loader.LoadTextureFromImage),
                    () => Output.ReleaseAndQuit(Output.Window, Output.Renderer, IntPtr.Zero, Texture));
            }
        }

        public Asset(Size size) : this()
        {
            Size = size;
        }

        public Asset(Size size, Position position) : this()
        {
            Size = size;
            Position = position;
        }
        public virtual void Render() =>
            Drawer.RenderTexture(Texture, Output.Renderer, Position.Width, Position.Height, Size.Width, Size.Height);

        public abstract void Clicked(Position mousePosition);
    }
}