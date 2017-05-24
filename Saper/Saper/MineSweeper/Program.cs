using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Saper
{
    static class Program
    {
        /// <summary>
        /// Główny punkt aplikacji 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Plansza());
        }
    }
}
