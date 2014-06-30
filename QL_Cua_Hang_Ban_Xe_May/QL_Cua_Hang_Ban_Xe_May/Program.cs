using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BaoCao;

namespace QL_Cua_Hang_Ban_Xe_May
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmChinh());
           
        }
    }
}
