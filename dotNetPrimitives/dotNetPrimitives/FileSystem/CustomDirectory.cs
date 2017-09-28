using System;
using System.IO;

namespace DotNetPrimitives.FileSystem
{
    public class CustomDirectory:IDirectory
    {
        public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public bool Exists(string dir)
        {
            return Directory.Exists(dir);
        }

        public DirectoryInfo CreateDirectory(string dir)
        {
            return Directory.CreateDirectory(dir);
        }

        public void Delete(string dir)
        {
            Directory.Delete(dir);
        }
    }
}
