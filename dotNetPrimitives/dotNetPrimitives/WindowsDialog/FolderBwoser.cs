using System.Windows.Forms;

namespace DotNetPrimitives.WindowsDialog
{
    public interface IDialog
    {
        DialogResult ShowDialog();
        string SelectedPath { get; set; }
    }
    public class FolderBwoser : IDialog
    {
        private FolderBrowserDialog _dialog = new FolderBrowserDialog();
        public string SelectedPath { get => _dialog.SelectedPath; set => _dialog.SelectedPath=value; }

        public DialogResult ShowDialog()
        {
           return _dialog.ShowDialog();
        }
    }
}
