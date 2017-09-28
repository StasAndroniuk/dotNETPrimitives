using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetPrimitives.WindowsMessages
{
    public interface IMessageBox
    {
        DialogResult Show(string text, string title, MessageBoxButtons buttons);
    }
}
