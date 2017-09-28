using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DotNetPrimitives.Processes
{
    public class CustomProcess : IProcess
    {
        public Process Start(string process)
        {
            return Process.Start(process);
        }

        public Process Start(string process, string startParams)
        {
            return Process.Start(process, startParams);
        }
    }
}
