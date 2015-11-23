using Client.API.Models;
using Microsoft.AspNet.SignalR;
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

            Random rnd = new Random();
            List<int> aantallen = new List<int>(); //waardes
            aantallen.Add(3);
            aantallen.Add(4);
            aantallen.Add(5);

            List<string> antwoordnamen = new List<string>();
            antwoordnamen.Add("ja");
            antwoordnamen.Add("nee");
            antwoordnamen.Add("misschien");

            string vraagNaam = "Naar huis?"; //naam van vraag

            diagram diagram = new diagram(aantallen, antwoordnamen, vraagNaam);
            diagram.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question q = Question.getById(3);
            Console.WriteLine(q.Text);
        }
    }
}
