using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Models;

namespace LogicGates.Engine
{
    public class Harness
    {
        public Engine.Output EngineOutput { get; set; } = null;
        public Engine.Input EngineInput { get; set; } = null;
        public Models.Level GameCurrentLevel { get; set; } = null;

        public Harness()
        {
            EngineOutput = new Engine.Output();
            GameCurrentLevel = new Models.Level00();

            foreach (var item in GameCurrentLevel.AsstesList)
            {
                item.Render(Output.Renderer);
            }

            SDL.SDL_RenderPresent(Output.Renderer);
            var reverseAssetList = new List<Asset>(GameCurrentLevel.AsstesList);
            reverseAssetList.Reverse();
            EngineInput = new Engine.Input(reverseAssetList);
        }
    }
}