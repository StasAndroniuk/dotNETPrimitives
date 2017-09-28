using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetPrimitives.WindowsMessages
{
    public class CustomMessageBox : IMessageBox
    {
        public DialogResult Show(string text, string title, MessageBoxButtons buttons)
        {
           return MessageBox.Show(text, title, buttons);
        }
    }
}
