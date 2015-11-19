using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class diagram : Form
    {
        //als er geen antwoordnamen worden meegegeven
        public diagram(int[] aantallen, string vraagNaam)
        {
            InitializeComponent();

            //maken van namen voor antwoorden 1,2,3,4,5,......
            string[] antwoordnamen = new string[aantallen.Length];

            for (int i = 0; i < aantallen.Length; i++)
            {
                antwoordnamen[i] = i + 1 + "";
            }
            //alle staven toevoegen aan diagram
            for (int i = 0; i < antwoordnamen.Length; i++)
            {
                chart1.Series.Add(MaakStaaf(antwoordnamen[i], aantallen[i]));
            }
            //vraag toevoegen boven het scherm
            textBox1.Text = vraagNaam;

            Invalidate();
        }

        public diagram(int[] aantallen, string[] antwoordnamen, string vraagNaam)
        {
            InitializeComponent();

            //alle staven toevoegen aan diagram
            for (int i = 0; i < antwoordnamen.Length; i++)
            {
                chart1.Series.Add(MaakStaaf(antwoordnamen[i], aantallen[i]));
            }
            //vraag toevoegen boven het scherm
            textBox1.Text = vraagNaam;

            Invalidate();
        }

        //maken van een staaf
        public Series MaakStaaf(string andwoordnaam, int aantal)
        {
            DataPoint staaf = new DataPoint();
            staaf.XValue = 1;               //x-as waarde(waarde niet relevant zolang alles maar gelijk)
            double[] aantallen = { aantal };//y-as waarde
            staaf.YValues = aantallen;

            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = andwoordnaam; //naam staaf
            series.Points.Add(staaf);
            return series;
        }
    }
}
