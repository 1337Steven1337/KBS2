using System.Windows.Forms;
using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client.View.Diagram
{
    public partial class ViewDiagram : Form, IDiagramView
    {
        private DiagramController controller;

        public ViewDiagram()
        {
            InitializeComponent();
        }

        public void setController(DiagramController controller)
        {
            this.controller = controller;
        }

        public Panel getPanel()
        {
            return panel1;
        }

        public void Make(List<int> values, List<string> answerNames, string question)
        {
            chart1.Series.Clear();

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                chart1.Series.Add(CreateColumn(answerNames[i], values[i]));
            }
            //add question above the diagram
            textBox1.Text = question;
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
