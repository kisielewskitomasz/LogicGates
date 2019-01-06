using System;
using System.IO;
using System.Reflection;

namespace LogicGates.Common
{
    /// <summary>
    /// Resolves relative paths to files
    /// </summary>
    public static class FilePath
    {
        static string _basePath = null;
        /// <summary>Keeps absolute path to Resources folder</summary>
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

        /// <summary>
        /// Gets relative path file
        /// </summary>
        /// <param name="fileName">File name</param>
        public static string Get(string fileName)
        {
            var path = Path.Combine(BasePath, fileName);

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(fileName);
            }

            return path;
        }

        /// <summary>
        /// Gets relative path to non existing file
        /// </summary>
        /// <param name="fileName">File name</param>
        public static string GetNotExisting(string fileName)
        {
            return Path.Combine(BasePath, fileName); ;
        }
    }
}