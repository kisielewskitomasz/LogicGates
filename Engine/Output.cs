using System;
using SDL2;

namespace LogicGates.Engine
{
    public class Output
    {
        public IntPtr Window { get; private set; } = IntPtr.Zero;
        public Output()
        {
            #if DEBUG
                SDL.SDL_SetHint(SDL.SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING, "1");
            #endif

            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO | SDL.SDL_INIT_AUDIO) < 0)
                SDLLogger.Fatal(nameof(SDL.SDL_Init));

            Window = SDL.SDL_CreateWindow("LogicGates", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                                            1024, 768, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);

            if (Window == IntPtr.Zero)
                SDLLogger.Fatal(nameof(SDL.SDL_CreateWindow),
                () => ReleaseAndQuit(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));

            var renderer = SDL.SDL_CreateRenderer(Window, -1,
                SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED | SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);

            if(renderer == IntPtr.Zero)
                SDLLogger.Fatal(nameof(SDL.SDL_CreateRenderer),
                    () => ReleaseAndQuit(Window, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));
        }

        ~Output()
        {
            SDL.SDL_DestroyWindow(Window);
            SDL.SDL_Quit();
        }

        private bool ReleaseAndQuit(IntPtr window, IntPtr renderer, IntPtr font, IntPtr image)
        {
            if(window != IntPtr.Zero)
                SDL.SDL_DestroyWindow(window);

            if(renderer != IntPtr.Zero)
                SDL.SDL_DestroyRenderer(renderer);

            if(font != IntPtr.Zero)
                SDL_ttf.TTF_CloseFont(font);

            if(image != IntPtr.Zero)
                SDL.SDL_DestroyTexture(image);

            SDL_image.IMG_Quit();
            SDL.SDL_Quit();

            return false;
        }
    }
}
