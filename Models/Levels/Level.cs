using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;
using LogicGates.Models;
using LogicGates.Models.Elements;
namespace LogicGates.Models
{
    public abstract class Level
    {
        public List<Asset> AsstesList { get; private set; } = new List<Asset>();
        public List<Element> ElementsList { get; private set; } = new List<Element>();
        public List<Lamp> LampsList { get; private set; } = new List<Lamp>();
        public List<Gate> GatesList { get; private set; } = new List<Gate>();
        public List<Connection> ConnectionsList { get; private set; } = new List<Connection>();


        public Level()
        {
            AsstesList.Add(new Images.Background());

            SDL.SDL_RenderClear(Output.Renderer);
        }
    }
}