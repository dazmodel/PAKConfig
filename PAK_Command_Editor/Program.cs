using PAK_Command_Editor.Repository;
using PAK_Command_Editor.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PAK_Command_Editor
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
            PAKDataSessionFactory.Init(PAKSettingsManager.Settings.DataBaseLocation, false);
            Application.Run(new MainForm());
        }
    }
}
