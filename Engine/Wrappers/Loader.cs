using System;
using SDL2;
using LogicGates.Common;

namespace LogicGates.Engine
{
    /// <summary>
    /// Wrapper for loading textures
    /// </summary>
    public static class Loader
    {
        public static IntPtr LoadTextureFromBitmap(string fileName, IntPtr renderer)
        {
            var texture = IntPtr.Zero;

            var image = SDL.SDL_LoadBMP(FilePath.Get(fileName));

            if (image != IntPtr.Zero)
            {
                texture = SDL.SDL_CreateTextureFromSurface(renderer, image);
                SDL.SDL_FreeSurface(image);

                if (texture == IntPtr.Zero)
                {
                    Logger.Error(nameof(SDL.SDL_CreateTextureFromSurface));
                }
            }
            else
            {
                Logger.Error(nameof(SDL.SDL_LoadBMP));
            }

            return texture;
        }

        public static IntPtr LoadTextureFromImage(string fileName, IntPtr renderer)
        {
            var texture = SDL_image.IMG_LoadTexture(renderer, FilePath.Get(fileName));

            if (texture == IntPtr.Zero)
            {
                Logger.Error(nameof(SDL_image.IMG_LoadTexture));
            }

            return texture;
        }
    }
}