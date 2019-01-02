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
            AsstesList.Add(new Images.Background());
            SDL.SDL_RenderClear(Output.Renderer);
        }

        public void Add(Asset asset)
        {
            AsstesList.Add(asset);
        }

         public void Remove(Asset asset)
        {
            AsstesList.Remove(asset);
        }
    }
}