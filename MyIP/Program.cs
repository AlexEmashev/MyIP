using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyIP
{
    static class Program
    {
        /// <summary>
        /// Current localisation.
        /// </summary>
        public static Localizator Localisation;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Localisation = Localizator.GetLocalization();
            Application.Run(new FormMyIP());
            //Localizator.SaveLocalization(Localisation);
            Properties.Settings.Default.CurrentLocale = Localisation.FileName;
            Properties.Settings.Default.Save();
        }
    }
}
