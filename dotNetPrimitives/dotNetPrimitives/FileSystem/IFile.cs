using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPrimitives.FileSystem
{
    public interface IFile
    {
        void Delete(string file);
        void Copy(string sourse, string destination, bool overwride);
        FileStream Open(string path, FileMode mode);
    }
}
