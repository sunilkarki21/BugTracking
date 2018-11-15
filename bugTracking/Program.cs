using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugTracking
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

            Application.Run(new login());
            //  Application.Run(new user.Dashboard());
           //  Application.Run(new admin_dashboard());
            // Application.Run(new user.ViewUsers());
            // Application.Run(new user.BugReport());
            //Application.Run(new programmer.ProgrammerPanel());

        }
    }
}
