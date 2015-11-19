using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test scenario
            Random rnd = new Random();
            int q = 0;
            int[] aantallen = new int[rnd.Next(50)]; //waardes
            for (int i = 0; i < aantallen.Length; i++) { aantallen[i] = rnd.Next(50); }
            string[] antwoordnamen = new string[aantallen.Length];
            for (int i = 0; i < aantallen.Length; i++) { q++; antwoordnamen[i] = q+""; }
            string vraagNaam = "Vote for president"; //naam van vraag

            if (aantallen.Length != antwoordnamen.Length) { Console.WriteLine("antwoorden aantallen niet gelijk"); } //bugfix
            else
            {
                diagram diagram = new diagram(aantallen, antwoordnamen, vraagNaam);
                diagram.Show();
            }
        }
    }
}
