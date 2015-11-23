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
        public diagram(int[] values, string[] answerNames, string question)
        {

            InitializeComponent();

            //add coloms to the diagram
            for (int i = 0; i < answerNames.Length; i++)
            {
                chart1.Series.Add(CreateColom(answerNames[i], values[i]));
            }
            //add question above the diagram
            textBox1.Text = question;

            Invalidate();
        }

        //create colom
        public Series CreateColom(string answerName, int value)
        {
            DataPoint staaf = new DataPoint();
            staaf.XValue = 5;             //x value
            double[] values = { value };  //y value
            staaf.YValues = values;

            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = answerName; //name colom
            series.Points.Add(staaf);
            return series;
        }
    }
}
