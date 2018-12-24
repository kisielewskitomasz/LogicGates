using System;
using SDL2;

namespace LogicGates.Models
{
    public class Output
    {
        IntPtr _window = IntPtr.Zero;
        public Output()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            _window = SDL.SDL_CreateWindow("LogicGates", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                                            1024, 768, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
        }

        ~Output()
        {
            SDL.SDL_DestroyWindow(_window);
            SDL.SDL_Quit();
        }
    }
}
