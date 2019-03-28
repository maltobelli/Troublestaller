using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troublestaller
{
    public static class Program
    {

        public static bool Uninstall = false;
        public static string LogPath = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Handle Command line arguments
            if(Environment.GetCommandLineArgs().Count() > 0)
            {
                string lastSwitch = "";
                foreach(string arg in Environment.GetCommandLineArgs())
                {
                    if(arg.ToLower().Equals("/u"))
                    {
                        Uninstall = true;
                    }else if(arg.ToLower().Equals("/l")) {
                        lastSwitch = "/l";
                    }
                    else if (arg.ToLower().Equals("/?"))
                    {
                        System.Windows.Forms.MessageBox.Show("Arguments are:\r\n\r\n/u - Uninstall\r\n/l <path> - Log to a path");
                    }
                    else
                    {
                        if(lastSwitch.Equals("/l"))
                        {
                            LogPath = arg;
                        }
                    }

                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TroubleStallerForm());
        }
    }
}
