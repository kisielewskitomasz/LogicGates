using System;
using SDL2;

namespace LogicGates.Models
{
    public class Output
    {
        IntPtr _window = IntPtr.Zero;
        public Output()
        {
            #if DEBUG
                SDL.SDL_SetHint(SDL.SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING, "1");
            #endif

            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO | SDL.SDL_INIT_AUDIO) < 0)
            {
                Console.WriteLine($"Unable to initialize SDL. Error: {SDL.SDL_GetError()}");
                return;
            }

            _window = SDL.SDL_CreateWindow("LogicGates", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                                            1024, 768, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);

            if (_window == IntPtr.Zero)
            {
                Console.WriteLine($"Unable to create a window. SDL. Error: {SDL.SDL_GetError()}");
                return;
            }
        }

        ~Output()
        {
            SDL.SDL_DestroyWindow(_window);
            SDL.SDL_Quit();
        }
    }
}
