using System.Windows.Forms;
using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System;
using Client.Service.Thread;
using MetroFramework.Forms;

namespace Client.View.Diagram
{
    public partial class DiagramView : MetroForm, IDiagramView
    {
        private DiagramController controller;

        public DiagramView()
        {
            InitializeComponent();

            this.FormClosed += DiagramView_FormClosed;
        }

        private void DiagramView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.controller.Dispose();
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
            labelQuestion.Text = question;
        }

        //Returns the table, with all the fields included
        public TableLayoutPanel getTable()
        {
            return tableWrapper;
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.labelQuestion);
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.controller = (DiagramController)controller;
        }
    }
}
