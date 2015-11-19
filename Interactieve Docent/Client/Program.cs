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

            int[] aantallen = new int[] {6,4,10,59};
            string[] antwoordnamen = new string[] {"Q, ","Q is the ","answer to ","EVERYTHING!!"};
            string vraagNaam = "Wat doen we aan het fileprobleem? En de politiek dan?";
            Application.Run(new diagram(aantallen,antwoordnamen,vraagNaam));

            Application.Run(new DocentForm());
        }
    }
}
