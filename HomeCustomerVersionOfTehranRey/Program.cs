using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeCustomerVersionOfTehranRey
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeCustomerVersionOfTehranRey.Forms.frmMain());
        }
    }
}