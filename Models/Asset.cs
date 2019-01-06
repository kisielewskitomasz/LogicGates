using System;
using System.Collections.Generic;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Models
{
    /// <summary>
    /// Defines basic in-game object
    /// </summary>
    public abstract class Asset
    {
        /// <summary>Keeps filenames assosiated with Asset</summary>
        protected abstract string[] FileNames { get; set; }
        /// <summary>Keeps pointers to textures assosiated with Asset</summary>
        public virtual IntPtr[] TexturesClip { get; protected set; }
        /// <summary>Keeps info about current used textures</summary>
        public virtual int CurrentTexture { get; set; } = 0;
        /// <summary>Keeps info about ability to move Asset</summary>
        public virtual bool IsMovable { get; set; } = false;
        /// <summary>Keeps info about Asset's Size</summary>
        public abstract Size Size { get; protected set; }
        /// <summary>Keeps info about Asset's Position</summary>
        public Position Position = new Position();

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Asset()
        {
            LoadTexture();
        }

        /// <summary>
        /// Constructs Asset with given Size
        /// </summary>
        /// <param name="size">Size of Asset</param>
        public Asset(Size size) : this()
        {
            Size = size;
        }

        /// <summary>
        /// Constructs Asset with given Position
        /// </summary>
        /// <param name="position">Position of Asset</param>
        public Asset(Position position) : this()
        {
            Position = position;
        }

        /// <summary>
        /// Constructs Asset with given Size and Position
        /// </summary>
        /// <param name="size">Size of Asset</param>
        /// <param name="position">Position of Asset</param>
        public Asset(Size size, Position position) : this()
        {
            Size = size;
            Position = position;
        }

        /// <summary>
        /// Loads Asset texture
        /// </summary>
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

        /// <summary>
        /// Changes Asset texture to another one
        /// </summary>
        public virtual void ChangeState()
        {
            CurrentTexture = (CurrentTexture + 1) % 2;
            Harness.RefreshOutput();
        }

        /// <summary>
        /// Changes Asset texture to second one
        /// </summary>
        public virtual void ChangeStateToHigh()
        {
            CurrentTexture = 1;
            Harness.RefreshOutput();
        }

        /// <summary>
        /// Changes Asset texture to first one
        /// </summary>
        public virtual void ChangeStateToLow()
        {
            CurrentTexture = 0;
            Harness.RefreshOutput();
        }

        /// <summary>
        /// Renders Asset on Canvas
        /// </summary>
        public virtual void Render() =>
            Drawer.RenderTexture(TexturesClip[CurrentTexture], Output.Renderer, Position.Width, Position.Height, Size.Width, Size.Height);

        /// <summary>
        /// Handler for left mouse button click on Asset
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {

        }

        /// <summary>
        /// Handler for left mouse button click on Asset's Input pins
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedLeftOnInput(Position mousePosition, Position relativeMousePosition)
        {

        }

        /// <summary>
        /// Handler for left mouse button click on Asset's Output pins
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedLeftOnOutput(Position mousePosition, Position relativeMousePosition)
        {

        }

        /// <summary>
        /// Handler for right mouse button click on Asset
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedRight(Position mousePosition, Position relativeMousePosition)
        {

        }

        /// <summary>
        /// Handler for right mouse button click on Asset's Input pins
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedRightOnInput(Position mousePosition, Position relativeMousePosition)
        {

        }

        /// <summary>
        /// Handler for right mouse button click on Asset's Output pins
        /// </summary>
        /// <param name="mousePosition">Size of Asset</param>
        /// <param name="relativeMousePosition">Position of Asset</param>
        public virtual void ClickedRightOnOutput(Position mousePosition, Position relativeMousePosition)
        {

        }
    }
}