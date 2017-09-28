using System.IO;

namespace DotNetPrimitives.FileSystem
{
    public interface IDirectory
    {
        string GetCurrentDirectory();
        string[] GetFiles(string path);
        bool Exists(string dir);
        DirectoryInfo CreateDirectory(string dir);
        void Delete(string dir);
    }
}
