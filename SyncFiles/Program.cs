using System;
using System.Windows.Forms;

namespace SyncFiles
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MainSettings.Default.appPath = Application.StartupPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_Main());
        }
    }
}
