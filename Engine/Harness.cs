using System;
using SDL2;

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

            EngineInput = new Engine.Input();
        }
    }
}