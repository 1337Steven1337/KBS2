using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Controller.Question;
using Client.Service.SignalR;
using Client.Service.Thread;
using Client.View.Question;
using Client.Model;
using System.Net;
using Client.View.Diagram;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client.View.Docent
{
    public partial class DocentOmgevingView : Form, IView
    {
        private DocentOmgevingController controller;
        private DiagramController DiagramController;
        public Model.Question CurrentQuestion;


        public DocentOmgevingView()
        {
            InitializeComponent();

            DiagramView view = new DiagramView();
            this.DiagramController = new DiagramController(view);
            this.DiagramController.SetQuestion((Model.Question)this.QuestionsListBox.SelectedItem);
            view.Show();

        }
        public void Make(List<int> values, List<string> answerNames)
        {
            //clear the chart
            chart1.Series.Clear();

         //   Dictionary<string, int> Columns = new Dictionary<string, int>();
            //List<Color> Colors = new List<Color>() {
            //    Color.Black, Color.Blue, Color.Red, Color.Green, Color.Pink
            //};

            //initialize new instances for a diagram
            Series series = new Series();
            series.ChartArea = "ChartArea1";
          //  chart1.ChartAreas["ChartArea1"].RecalculateAxesScale();
          //  series.IsVisibleInLegend = false;

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                series.Points.AddXY(answerNames[i], values[i]);
                //give color to each individual column
              //  series.Points[i].Color = (i < 5) ? Colors[i] : Colors[(int)Math.Floor(((double)i / 5))];
            }
            chart1.Series.Add(series);
        }
        public Model.Question GetCurrentQuestion()
        {
            return (Model.Question)QuestionsListBox.SelectedItem;
        }
        public void FillList(List<Model.Question> list)
        {
            this.QuestionsListBox.Items.Clear();

            foreach (Model.Question question in list)
            {
                this.QuestionsListBox.Items.AddRange(new object[] { question.Text });
            }
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.QuestionsListBox);
        }

        public void SetController(IController controller)
        {
            this.controller = (DocentOmgevingController)controller;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().GoToNextQuestionOnClick(1);
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestionView view = new AddQuestionView(null);
            AddQuestionController controller = new AddQuestionController();
            controller.SetView(view);
            controller.SetQuestionList(this.controller.CurrentList);
            view.Show();
        }

        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
