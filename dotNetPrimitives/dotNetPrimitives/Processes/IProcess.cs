using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DotNetPrimitives.Processes
{
    public interface IProcess
    {
        Process Start(string process);
        Process Start(string process, string startParams);
    }
}
