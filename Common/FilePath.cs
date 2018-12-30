using System;
using System.IO;
using System.Reflection;

namespace LogicGates.Common
{
    public static class FilePath
    {
        static string _basePath = null;
        static string BasePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_basePath))
                {
                    _basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources");
                }

                return _basePath;
            }
        }

        public static string Get(string fileName)
        {
            var path = Path.Combine(BasePath, fileName);

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(fileName);
            }

            return path;
        }

        public static string GetNotExisting(string fileName)
        {
            return Path.Combine(BasePath, fileName); ;
        }

    }

}