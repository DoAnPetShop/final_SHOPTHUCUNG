using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static frmMain mainForm = null;
        public static frmMainNV mainnvForm = null;
        public static frmDangNhap loginForm = null;
        public static frmConnection connectForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new frmDangNhap();
            Application.Run(loginForm);
        }
    }
}
