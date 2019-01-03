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
        static int _state = 0;

        static Asset ClickedAsset { get; set; } = null;
        static Position MousePosition { get; set; } = new Position();
        static Position RelativeMousePosition { get; set; } = null;

        public Input()
        {
            SDL.SDL_Event e;

            while (!_quit)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    HandleEvent(e);
                }
            }
        }
        static void HandleEvent(SDL.SDL_Event e)
        {
            switch (e.type)
            {
                case SDL.SDL_EventType.SDL_QUIT:
                    OnSDL_QUIT();
                    break;
                case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                    OnSDL_MOUSEBUTTONDOWN();
                    break;
                case SDL.SDL_EventType.SDL_MOUSEMOTION:
                    OnSDL_MOUSEMOTION();
                    break;
            }
        }

        private static void OnSDL_MOUSEMOTION()
        {
            if (_state == 1)
            {
                SDL.SDL_GetMouseState(out MousePosition.Width, out MousePosition.Height);

                ClickedAsset.Position = MousePosition + RelativeMousePosition;

                Harness.RefreshOutput();
            }
        }

        static void OnSDL_MOUSEBUTTONDOWN()
        {
            var clickedButton = SDL.SDL_GetMouseState(out MousePosition.Width, out MousePosition.Height);
            if (clickedButton == SDL.SDL_BUTTON(SDL.SDL_BUTTON_LEFT))
            {
                System.Console.Write("Left ");
                ClickedAsset = FindClickedAsset(MousePosition);

                ClickedAsset.ClickedLeft(MousePosition);
                if ((ClickedAsset.IsMovable) && (_state == 0))
                {
                    RelativeMousePosition = (ClickedAsset.Position - MousePosition);
                    _state = 1;
                }
                else if ((ClickedAsset.IsMovable) && (_state == 1))
                {
                    _state = 0;
                }
            }
            else if (clickedButton == SDL.SDL_BUTTON(SDL.SDL_BUTTON_RIGHT))
            {
                System.Console.Write("Right ");
                ClickedAsset = FindClickedAsset(MousePosition);
                ClickedAsset.ClickedRight(MousePosition);
                _state = 0;
            }
        }

        private static void OnSDL_QUIT()
        {
            Harness.QuitGame();
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
