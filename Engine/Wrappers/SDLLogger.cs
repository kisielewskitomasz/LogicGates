using System;
using SDL2;

namespace LogicGates.Models
{
    public static class SDLLogger
    {
        /// <summary>
        /// Logs fatal errors into console. If cleanup delegate exits execute it, if not throws new exception.
        /// </summary>
        /// <param name="source">Error source</param>
        /// <param name="handler">Cleanup delegate (set to null if no additional cleanup needed, exception will be thrown)</param>
        public static void Fatal(string source, Func<bool> handler = null)
        {
            var message = $"{source} Error: {SDL.SDL_GetError()}";

            Console.WriteLine(message);

            if(!(handler != null && handler()))
            {
                throw new Exception(message);
            }
        }

        /// <summary>
        /// Logs normal errors into console.
        /// </summary>
        /// <param name="source">Error source</param>
        public static void Error(string source)
        {
            Console.WriteLine($"{source} Error: {SDL.SDL_GetError()}");
        }
    }
}