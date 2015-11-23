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
        public diagram(List<int> values, List<string> answerNames, string question)
        {

            InitializeComponent();

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                chart1.Series.Add(CreateColumn(answerNames[i], values[i]));
            }
            //add question above the diagram
            textBox1.Text = question;

            Invalidate();
        }

        //create column
        public Series CreateColumn(string answerName, int value)
        {
            DataPoint Column = new DataPoint();
            Column.XValue = 5;             //x value
            double[] values = { value };  //y value
            Column.YValues = values;

            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = answerName; //name column
            series.Points.Add(Column);
            return series;
        }
    }
}
