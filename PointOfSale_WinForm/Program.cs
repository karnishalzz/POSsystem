using PointOfSale_WinForm.Other;
using PointOfSale_WinForm.POS;
using PointOfSale_WinForm.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm
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
            Application.Run(new LicesnseForm());
        }
    }
}
