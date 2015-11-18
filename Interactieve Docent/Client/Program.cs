using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
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

            int[] aantallen = new int[] {6,4,10,20};
            string[] antwoordnamen = new string[] {"ja","nee","misschien","NEE!!"};
            string vraagNaam = "we gaan tot 6 uur door";
            Application.Run(new diagram(aantallen,antwoordnamen,vraagNaam));
        }
    }
}
