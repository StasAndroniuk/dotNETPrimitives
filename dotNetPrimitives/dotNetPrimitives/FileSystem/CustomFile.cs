using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPrimitives.FileSystem
{
    public class CustomFile:IFile
    {
        public void Delete(string file)
        {
            File.Delete(file);
        }

        public void Copy(string sourse, string destination, bool overwride)
        {
            File.Copy(sourse,destination,overwride);
        }
        public FileStream Open(string path, FileMode mode)
        {
            return File.Open(path, mode);
        }
    }
}
