using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Models;
using LogicGates.Common;

namespace LogicGates.Engine
{
    public class Input
    {
        bool _quit = false;
        public Input(List<Asset> assetsList)
        {
            SDL.SDL_Event e;

            while (!_quit)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            Quit();
                            break;
                        case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                            var mousePosition = new Position();
                                if (SDL.SDL_GetMouseState(out mousePosition.Width, out mousePosition.Height) == SDL.SDL_BUTTON(SDL.SDL_BUTTON_LEFT))
                                {
                                    System.Console.WriteLine($"Left click at: {mousePosition.Width}, {mousePosition.Height}");
                                    foreach (var asset in assetsList)
                                    {
                                        if ((mousePosition.Width >= asset.Position.Width) && (mousePosition.Width <= (asset.Position.Width + asset.Size.Width)) &&
                                            (mousePosition.Height >= asset.Position.Height) && (mousePosition.Height <= (asset.Position.Height + asset.Size.Height)))
                                        {
                                            System.Console.WriteLine($"Clicked on :{asset.ToString()}");
                                            asset.Clicked(mousePosition, this);
                                            break;
                                        }
                                    }
                                }
                            break;
                    }
                }
            }
        }

        public void Quit()
        {
            _quit = true;
        }
    }
}
