using System;
using SDL2;

namespace LogicGates.Engine
{
    public class Input
    {
        public Input()
        {
            SDL.SDL_Event e;
            bool quit = false;

            while (!quit)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            quit = true;
                            break;
                    }
                }
            }
        }
    }
}
