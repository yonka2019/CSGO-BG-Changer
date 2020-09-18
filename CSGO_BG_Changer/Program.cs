using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_BG_Changer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Setting language
            CultureInfo ci = CultureInfo.InstalledUICulture;
            if (ci.EnglishName.Contains("Russian"))
                Properties.Settings.Default.Language = "RU";
            else
                Properties.Settings.Default.Language = "EN";
            Properties.Settings.Default.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
