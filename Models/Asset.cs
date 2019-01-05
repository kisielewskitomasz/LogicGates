using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{

    public abstract class Asset
    {
        protected abstract string[] FileNames { get; set; }
        public virtual IntPtr[] TexturesClip { get; protected set; }
        public virtual int CurrentTexture { get; set; } = 0;
        public virtual bool IsMovable { get; set; } = false;
        public abstract Size Size { get; protected set; }
        public Position Position = new Position();

        public Asset()
        {
            LoadTexture();
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

        public virtual void LoadTexture()
        {
            if (FileNames.Length == 0)
            {
                TexturesClip[0] = IntPtr.Zero;
            }
            else
            {
                TexturesClip = new IntPtr[FileNames.Length];
                for(int i = 0; i < FileNames.Length; i++)
                {
                    TexturesClip[i] = Loader.LoadTextureFromImage(FileNames[i], Output.Renderer);

                    if (TexturesClip[i] == IntPtr.Zero)
                    {
                        Logger.Fatal(nameof(Loader.LoadTextureFromImage),
                            () => Output.ReleaseAndQuit(Output.Window, Output.Renderer, IntPtr.Zero, TexturesClip[i]));
                    }
                }
            }
        }
        public virtual void ChangeState()
        {
            CurrentTexture = (CurrentTexture + 1) % 2;
            Harness.RefreshOutput();
        }

        public virtual void ChangeStateToHigh()
        {
            CurrentTexture = 1;
            Harness.RefreshOutput();
        }

        public virtual void ChangeStateToLow()
        {
            CurrentTexture = 0;
            Harness.RefreshOutput();
        }
        public virtual void Render() =>
            Drawer.RenderTexture(TexturesClip[CurrentTexture], Output.Renderer, Position.Width, Position.Height, Size.Width, Size.Height);

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