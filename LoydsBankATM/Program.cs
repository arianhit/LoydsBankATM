using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoydsBankATM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CardEntery ce = new CardEntery();
            Application.Run(new CardEntery());

            if (ce.getCardValidated())
            {
                Application.Run(new ATMMenu());
            }
        }
    }
}
