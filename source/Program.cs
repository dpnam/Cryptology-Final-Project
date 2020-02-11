using System;
using System.Windows.Forms;

namespace MHTT_UD
{
    static class Program
    {
        /// <summary>
        /// 1612406 - Đặng Phương Nam
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
