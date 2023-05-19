using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.HomeWork;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();        
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //解決傳統的windows Forms在高解析度(Hight DPI)設定下，所引發的文字模糊問題
            if (System.Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmConnected_Insert());
            Application.Run(new FrmTravel());
        }
    }
}
