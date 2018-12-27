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

        public Asset(string fileName)
        {
            Texture = Loader.LoadTextureFromImage(fileName, Output.Renderer);

            if(Texture == IntPtr.Zero)
            {
                Logger.Fatal(
                    nameof(Loader.LoadTextureFromImage),
                    () => Output.ReleaseAndQuit(Output.Window, Output.Renderer, IntPtr.Zero, Texture));
            }
        }

        public Asset(string fileName, Size size) : this(fileName)
        {
            Size = size;
        }

        public Asset(string fileName, Size size, Position position) : this(fileName)
        {
            Size = size;
            Position = position;
        }

        public abstract void Render(IntPtr renderer);

        public abstract void Clicked(Position mousePosition, Input engineInput);
    }
}