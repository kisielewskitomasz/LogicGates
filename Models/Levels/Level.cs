using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models
{
    public abstract class Level
    {
        public List<Asset> AsstesList { get; private set; } = new List<Asset>();
        public List<Elements.Element> ElementsList { get; private set; } = new List<Elements.Element>();

        public Level()
        {
            AsstesList.Add(new Images.Background());

            SDL.SDL_RenderClear(Output.Renderer);
        }
    }
}