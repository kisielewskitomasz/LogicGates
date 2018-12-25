using System;
using System.IO;
using System.Reflection;

using SDL2;

namespace LogicGates.Engine
{
    public static class Loader
    {
        static string _basePath = null;
        static string BasePath
        {
            get
            {
                if(string.IsNullOrWhiteSpace(_basePath))
                {
                    _basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources");
                }

                return _basePath;
            }
        }

        static string GetFilePath(string fileName)
        {
            var path = Path.Combine(BasePath, fileName);

            if(!File.Exists(path))
            {
                throw new FileNotFoundException(fileName);
            }

            return path;
        }

        public static IntPtr LoadTextureFromBitmap(string fileName, IntPtr renderer)
        {
            var texture = IntPtr.Zero;

            var image = SDL.SDL_LoadBMP(GetFilePath(fileName));

            if(image != IntPtr.Zero)
            {
                texture = SDL.SDL_CreateTextureFromSurface(renderer, image);
                SDL.SDL_FreeSurface(image);

                if(texture == IntPtr.Zero)
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
            var texture = SDL_image.IMG_LoadTexture(renderer, GetFilePath(fileName));

            if(texture == IntPtr.Zero)
            {
                Logger.Error(nameof(SDL_image.IMG_LoadTexture));
            }

            return texture;
        }
    }
}