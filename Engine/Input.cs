using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Models;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Engine
{
    public class Input
    {
        static bool _quit = false;
        static bool _isMovable = false;
        static int _state = 0;
        public Input()
        {
            SDL.SDL_Event e;
            Asset clickedAsset = null;

            while (!_quit)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            {
                                Harness.QuitGame();
                                break;
                            }
                        case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                            {
                                var mousePosition = new Position();
                                if (SDL.SDL_GetMouseState(out mousePosition.Width, out mousePosition.Height) == SDL.SDL_BUTTON(SDL.SDL_BUTTON_LEFT))
                                {
                                    System.Console.Write("Left ");
                                    clickedAsset = FindClickedAsset(mousePosition);
                                    clickedAsset.ClickedLeft(mousePosition);
                                    if ((clickedAsset.IsMovable) && (_state == 0))
                                    {
                                        _state = 1;
                                    }
                                }

                                else if (SDL.SDL_GetMouseState(out mousePosition.Width, out mousePosition.Height) == SDL.SDL_BUTTON(SDL.SDL_BUTTON_RIGHT))
                                {
                                    System.Console.Write("Right ");
                                    clickedAsset = FindClickedAsset(mousePosition);
                                    clickedAsset.ClickedRight(mousePosition);
                                    _state = 0;
                                }
                                break;
                            }
                        case SDL.SDL_EventType.SDL_MOUSEMOTION:
                            {
                                if (_state == 1)
                                {
                                    var mousePosition = new Position();
                                    SDL.SDL_GetMouseState(out mousePosition.Width, out mousePosition.Height);
                                }
                                break;
                            }
                    }
                }
            }
        }

        private static Asset FindClickedAsset(Position mousePosition)
        {
            Asset _asset = null;
            var reversedAssetsList = new List<Asset>(Harness.GameCurrentLevel.AsstesList);
            reversedAssetsList.Reverse();
            foreach (var asset in reversedAssetsList)
            {
                if ((mousePosition.Width >= asset.Position.Width) && (mousePosition.Width <= (asset.Position.Width + asset.Size.Width)) &&
                    (mousePosition.Height >= asset.Position.Height) && (mousePosition.Height <= (asset.Position.Height + asset.Size.Height)))
                {
                    System.Console.WriteLine($"Click at: {mousePosition.Width}, {mousePosition.Height} on: {asset.ToString()}");
                    return asset;
                }
            }
            return _asset;
        }

        public static void Quit()
        {
            _quit = true;
        }
    }
}
