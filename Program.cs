using JasylTirsilik;
using Loader;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;



namespace KeyAuth
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
            Application.Run(new LoadingForm());

        }
    }
}
