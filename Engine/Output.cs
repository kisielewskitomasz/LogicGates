using System;
using SDL2;
using LogicGates.Common;

namespace LogicGates.Engine
{


    public class Output
    {
        public static IntPtr Window { get; private set; } = IntPtr.Zero;
        public static IntPtr Renderer { get; private set; } = IntPtr.Zero;

        public Output()
        {
#if DEBUG
            SDL.SDL_SetHint(SDL.SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING, "1");
#endif

            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO | SDL.SDL_INIT_AUDIO) < 0)
                Logger.Fatal(nameof(SDL.SDL_Init));

            if (SDL_image.IMG_Init(SDL_image.IMG_InitFlags.IMG_INIT_PNG) != (int)SDL_image.IMG_InitFlags.IMG_INIT_PNG)
            {
                SDL.SDL_SetError("IMG_Init failed.");
                Logger.Fatal(nameof(SDL_image.IMG_Init));
            }

            Window = SDL.SDL_CreateWindow("LogicGates", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                                            Canvas.Width, Canvas.Height, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            if (Window == IntPtr.Zero)
                Logger.Fatal(nameof(SDL.SDL_CreateWindow),
                () => ReleaseAndQuit(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));

            Renderer = SDL.SDL_CreateRenderer(Window, -1,
                SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED | SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);

            if (Renderer == IntPtr.Zero)
                Logger.Fatal(nameof(SDL.SDL_CreateRenderer),
                    () => ReleaseAndQuit(Window, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));

        }

        ~Output()
        {
            ReleaseAndQuit(Window, Renderer, IntPtr.Zero, IntPtr.Zero);
        }

        public static bool ReleaseAndQuit(IntPtr window, IntPtr renderer, IntPtr font, IntPtr image)
        {
            if (window != IntPtr.Zero)
                SDL.SDL_DestroyWindow(window);

            if (renderer != IntPtr.Zero)
                SDL.SDL_DestroyRenderer(renderer);

            if (font != IntPtr.Zero)
                SDL_ttf.TTF_CloseFont(font);

            if (image != IntPtr.Zero)
                SDL.SDL_DestroyTexture(image);

            SDL_image.IMG_Quit();
            SDL.SDL_Quit();

            return false;
        }
    }
}
