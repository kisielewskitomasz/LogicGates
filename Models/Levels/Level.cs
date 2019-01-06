using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;
using LogicGates.Models;
using LogicGates.Models.Elements;
namespace LogicGates.Models
{
    /// <summary>
    /// Defines basic level
    /// </summary>
    public abstract class Level
    {
        /// <summary>Keeps all Level assets</summary>
        public List<Asset> AsstesList { get; private set; } = new List<Asset>();
        /// <summary>Keeps all Level elements</summary>
        public List<Element> ElementsList { get; private set; } = new List<Element>();
        /// <summary>Keeps all Level lamps</summary>
        public List<Lamp> LampsList { get; private set; } = new List<Lamp>();
        /// <summary>Keeps all Level gates</summary>
        public List<Gate> GatesList { get; private set; } = new List<Gate>();
        /// <summary>Keeps all Level connections</summary>
        public List<Connection> ConnectionsList { get; private set; } = new List<Connection>();

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Level()
        {
            AsstesList.Add(new Images.Background());

            SDL.SDL_RenderClear(Output.Renderer);
        }
    }
}