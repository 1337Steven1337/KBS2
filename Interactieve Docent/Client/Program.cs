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

            //test scenario
            int[] aantallen = new int[] { 6, 4, 10, 5, 111, 2, 4, 1, 7 }; //waardes
            string[] antwoordnamen = new string[] { "piet", "henk", "klaas", "jan", "kees", "truus", "hans", "alex", "simon" }; //namen van antwoorden
            string vraagNaam = "Vote for president"; //naam van vraag
            if (aantallen.Length != antwoordnamen.Length) { Console.WriteLine("antwoorden aantallen niet gelijk"); } //bugfix
            else
            {
                Application.Run(new diagram(aantallen, antwoordnamen, vraagNaam)); //maak diagram
            }
        }
    }
}
