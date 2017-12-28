using SLWModLoader.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace SLWModLoader
{
    public static class Program
    {
        // Variables/Constants
        public const string Name = "SLW Mod Loader";
        public const float Version = 6.0f;

        public static string ModsDBPath
        {
            get
            {
                return Path.Combine(Settings.Default.ModsDirectory, "ModsDB.ini");
            }
        }

        // Methods
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}