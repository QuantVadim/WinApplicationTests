using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_tests.Classes;

namespace Win_tests
{
    static class Program
    {
        public static User user;
        public static MainForm mainForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.Initialization("localhost", "postgres", "postgres", "win_tests");
            
            Application.Run(new Form1());
        }
    }
}
