using App.Presenters;
using System;
using System.Windows.Forms;

namespace App
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
            var ap = new ApplicationUI();
            new MainPresenter(ap);
            Application.Run(ap);
        }
    }
}
