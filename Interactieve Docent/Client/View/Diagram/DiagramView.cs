using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System;

namespace Client.View.Diagram
{
    public partial class DiagramView : Form, IDiagramView
    {
        private DiagramController controller;
        private Panel panel;

        public DiagramView()
        {
            InitializeComponent();
        }

        public void setController(DiagramController controller)
        {
            this.controller = controller;
        }

        public void setPanel<T>(Panel panel)
        {
            this.panel = panel;
        }

        public Panel getPanel()
        {
            return this.panel;
        }

        public void Make(List<int> values, List<string> answerNames, string question)
        {
            //clear the chart
            chart1.Series.Clear();
            
            Dictionary<string, int> Columns = new Dictionary<string, int>();
            List<Color> Colors = new List<Color>() {
                Color.Black, Color.Blue, Color.Red, Color.Green, Color.Pink
            };

            //initialize new instances for a diagram
            Series series = new Series();
            series.ChartArea = "ChartArea1";
            chart1.ChartAreas["ChartArea1"].RecalculateAxesScale();
            series.IsVisibleInLegend = false;

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                series.Points.AddXY(answerNames[i], values[i]);
                //give color to each individual column
                series.Points[i].Color = (i < 5) ? Colors[i] : Colors[(int)Math.Floor(((double)i / 5))];
            }
            chart1.Series.Add(series);
            //add question above the diagram
            textBox1.Text = question;
        }
    }
}
