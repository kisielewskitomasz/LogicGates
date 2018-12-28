using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Level
    {
        public List<Asset> AsstesList { get; private set; } = null;

        public Level()
        {
            AsstesList = new List<Asset>();
            AsstesList.Add(new Background(new Size {Width = 1024, Height = 768}));
            SDL.SDL_RenderClear(Output.Renderer);
        }
    }
}