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
       public diagram(int[] aantallen, string[] antwoordnamen, string vraagNaam) {
           
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
            staaf.XValue = 5;               //x-as waarde
            double[] aantallen = { aantal, 6 };//y-as waarde
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
