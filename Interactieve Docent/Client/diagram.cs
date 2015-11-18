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


        //als er geen namen worden meegegeven
        public diagram(int[] aantallen, string vraagNaam)
        {
            InitializeComponent();

            string[] antwoordnamen = new string[aantallen.Length];

            for (int i = 0; i < aantallen.Length; i++)
            {
                antwoordnamen[i] = i + 1 + "";
            }
            
            for (int i = 0; i < antwoordnamen.Length; i++)
            {
                chart1.Series.Add(MaakStaaf(antwoordnamen[i], aantallen[i]));
            }

            textBox1.Text = vraagNaam;

            Invalidate();
        }

        public diagram(int[] aantallen, string[] antwoordnamen, string vraagNaam)
        {
            InitializeComponent();

            for (int i = 0; i < antwoordnamen.Length; i++)
            {
                chart1.Series.Add(MaakStaaf(antwoordnamen[i], aantallen[i]));
            }

            textBox1.Text = vraagNaam;

            Invalidate();
        }
        public Series MaakStaaf(string andwoordnaam, int aantal)
        {
            DataPoint staaf = new DataPoint();
            staaf.XValue = 1;
            double[] aantallen = { aantal };
            staaf.YValues = aantallen;

            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = andwoordnaam;
            series.Points.Add(staaf);
            return series;
        }

     }
}
