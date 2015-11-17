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
        public diagram(int aantalJa,int aantalNee)
        {
            InitializeComponent();
            //maken van x.y punt voor ja
            DataPoint ja = new DataPoint();
            ja.XValue = 0;
            double[] aantalja = { aantalJa };
            ja.YValues = aantalja;

            //maken van x.y punt voor ja
            DataPoint nee = new DataPoint();
            nee.XValue = 0;
            double[] aantalnee = { aantalNee };
            nee.YValues = aantalnee;

            //aanmaken van staaf ja
            Series seriesja = new Series();
            seriesja.ChartArea = "ChartArea1";
            seriesja.Legend = "Legend1";
            seriesja.Name = "ja";
            seriesja.Points.Add(ja);

            //aanmaken van staaf nee
            Series seriesnee = new Series();
            seriesnee.ChartArea = "ChartArea1";
            seriesnee.Legend = "Legend1";
            seriesnee.Name = "nee";
            seriesnee.Points.Add(nee);

            chart1.Series.Add(seriesnee);
            chart1.Series.Add(seriesja);
        }
    }
}
