using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Models;
using LogicGates.Models.Elements;
using LogicGates.Engine;
using LogicGates.Common;

namespace LogicGates.Engine
{
    /// <summary>
    /// Handles input form user
    /// </summary>
    public class Input
    {
        static bool _quit = false;
        static Defs.Mouse MouseState { get; set; } = 0;
        static Asset ClickedAsset { get; set; } = null;
        static Pin ClickedAssetPin { get; set; } = null;
        static Pin SelectedAssetPin { get; set; } = null;
        static Position MousePosition { get; set; } = new Position();
        static Position RelativeMousePosition { get; set; } = new Position();

        /// <summary>
        /// Basic constructor
        /// </summary>
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
        /// <summary>
        /// Handles input events
        /// </summary>
        /// <param name="e">Comming event sent by SDL Engine</param>
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

        /// <summary>
        /// Handler for mouse buttons clicks
        /// </summary>
        static void OnSDL_MOUSEBUTTONDOWN()
        {
            var clickedButton = SDL.SDL_GetMouseState(out MousePosition.Width, out MousePosition.Height);
            if (clickedButton == SDL.SDL_BUTTON(SDL.SDL_BUTTON_LEFT))
            {
                System.Console.Write("Left ");
                FindClickedAsset(MousePosition);
                ClickedAsset.ClickedLeft(MousePosition, RelativeMousePosition);

                if ((MouseState == Defs.Mouse.Idle))
                {
                    if (ClickedAsset is Element)
                    {
                        if ((ClickedAssetPin != null) && (!((Element)ClickedAsset).IsInTray()))
                        {
                            SelectedAssetPin = ClickedAssetPin;
                            MouseState = Defs.Mouse.Select;
                        }
                        else if (ClickedAsset.IsMovable)
                        {
                            MouseState = Defs.Mouse.Move;
                        }
                    }
                }
                else if (MouseState == Defs.Mouse.Move)
                {
                    MouseState = Defs.Mouse.Idle;
                }
                else if (MouseState == Defs.Mouse.Select)
                {
                    if (ClickedAssetPin == null)
                    {
                        MouseState = Defs.Mouse.Idle;
                    }
                    else if ((SelectedAssetPin.Type != ClickedAssetPin.Type) && (SelectedAssetPin.Element != ClickedAssetPin.Element) && (!((Element)ClickedAsset).IsInTray()))
                    {
                        var connection = new Connection(SelectedAssetPin, ClickedAssetPin);
                        foreach (var item in connection.WiresList)
                        {
                            Harness.GameCurrentLevel.AsstesList.Add(item);
                        }
                        Harness.GameCurrentLevel.ConnectionsList.Add(connection);
                        Harness.RefreshOutput();
                        MouseState = Defs.Mouse.Idle;
                    }
                    else
                    {
                        ClickedAssetPin = null;
                        SelectedAssetPin = null;
                        MouseState = Defs.Mouse.Idle;
                    }
                }
            }
            else if (clickedButton == SDL.SDL_BUTTON(SDL.SDL_BUTTON_RIGHT))
            {
                System.Console.Write("Right ");
                FindClickedAsset(MousePosition);
                ClickedAsset.ClickedRight(MousePosition, RelativeMousePosition);
                MouseState = Defs.Mouse.Idle;
            }
        }

        /// <summary>
        /// Handler for mouse moving
        /// </summary>
        static void OnSDL_MOUSEMOTION()
        {
            if (MouseState == Defs.Mouse.Move)
            {
                SDL.SDL_GetMouseState(out MousePosition.Width, out MousePosition.Height);
                ClickedAsset.Position = MousePosition - RelativeMousePosition;
                Harness.RefreshOutput();
            }
        }

        /// <summary>
        /// Handler for quit the game
        /// </summary>
        static void OnSDL_QUIT()
        {
            Harness.QuitGame();
        }

        /// <summary>
        /// Helper which finds clicked Asset
        /// </summary>
        /// <param name="mousePosition">Mouse positon on click</param>
        static void FindClickedAsset(Position mousePosition)
        {
            var reversedAssetsList = new List<Asset>(Harness.GameCurrentLevel.AsstesList);
            reversedAssetsList.Reverse();
            foreach (var asset in reversedAssetsList)
            {
                if ((mousePosition.Width >= asset.Position.Width) && (mousePosition.Width <= (asset.Position.Width + asset.Size.Width)) &&
                    (mousePosition.Height >= asset.Position.Height) && (mousePosition.Height <= (asset.Position.Height + asset.Size.Height)))
                {
                    System.Console.WriteLine($"Click at: {mousePosition.Width}, {mousePosition.Height} on: {asset.ToString()}");
                    ClickedAsset = asset;
                    RelativeMousePosition = (MousePosition - ClickedAsset.Position);
                    if (ClickedAsset is Element)
                        FindClickedAssetPin(mousePosition);
                    return;
                }
            }
            ClickedAsset = null;
        }

        /// <summary>
        /// Helper which finds clicked Asset's Pin
        /// </summary>
        /// <param name="mousePosition">Mouse positon on click</param>
        static void FindClickedAssetPin(Position mousePosition)
        {
            foreach (var pin in ((Element)ClickedAsset).PinsList)
            {
                if ((RelativeMousePosition.Width >= pin.Position.Width) && (RelativeMousePosition.Width <= (pin.Position.Width + pin.Size.Width)) &&
                    (RelativeMousePosition.Height >= pin.Position.Height) && (RelativeMousePosition.Height <= (pin.Position.Height + pin.Size.Height)))
                {
                    if (!pin.isConnected)
                    {
                        ClickedAssetPin = pin;
                        System.Console.WriteLine($"Click at: {RelativeMousePosition.Width}, {RelativeMousePosition.Height} on: {ClickedAssetPin.ToString()} - {ClickedAssetPin.Type.ToString()}");
                        return;
                    }
                }
            }
            ClickedAssetPin = null;
        }

        /// <summary>
        /// Helper which terminates Input while loop
        /// </summary>
        public static void Quit()
        {
            _quit = true;
        }
    }
}
