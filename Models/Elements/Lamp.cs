using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models.Elements
{
    public abstract class Lamp : Element
    {
        protected abstract string FileNameAlt { get; set; }
        protected virtual bool IsAltTexture  { get; set; } = false;
        public override List<Pin> PinsList { get; protected set; } = new List<Pin> { new Pin(0, 33, IO.In), new Pin(66, 33, IO.Out) };
        public Lamp() : base()
        {
        }

        public Lamp(Size size) : base(size)
        {
        }

        public Lamp(Position position) : base(position)
        {
        }

        public Lamp(Size size, Position position) : base(size, position)
        {
        }

        public virtual void ChangeState()
        {
            IsAltTexture = !IsAltTexture;

            if (!IsAltTexture)
                Texture = Loader.LoadTextureFromImage(FileName, Output.Renderer);
            else
                Texture = Loader.LoadTextureFromImage(FileNameAlt, Output.Renderer);

            if (Texture == IntPtr.Zero)
            {
                Logger.Fatal(nameof(Loader.LoadTextureFromImage),
                    () => Output.ReleaseAndQuit(Output.Window, Output.Renderer, IntPtr.Zero, Texture));
            }

            Harness.RefreshOutput();

        }
    }
}