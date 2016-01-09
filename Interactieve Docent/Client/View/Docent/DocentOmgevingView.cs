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
        public int CurrentSelectedQuestion; //indicates which index is selected


        public DocentOmgevingView()
        {
            InitializeComponent();

            DiagramView view = new DiagramView();
            this.DiagramController = new DiagramController(view);
            QuestionsListBox.Enabled = false; //disabled list selection
            this.DiagramController.SetQuestion((Model.Question)this.QuestionsListBox.SelectedItem);
            // view.Show();

        }
        //fill diagram NEED WORK!
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
        //fill questionslistbox with the previous selected list
        public void FillList(List<Model.Question> list)
        {
            this.QuestionsListBox.Items.Clear();
        
            foreach (Model.Question question in list)
            {
                this.QuestionsListBox.Items.AddRange(new object[] { question.Text });
            }
            QuestionsListBox.SelectedIndex = CurrentSelectedQuestion;
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

        //the students go to the next question
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().GoToNextQuestionOnClick(1); //go to next question
            int max = QuestionsListBox.Items.Count - 1; //can't go over the current amount of questions
            if (QuestionsListBox.SelectedIndex != max) { 
              QuestionsListBox.SetSelected((int)QuestionsListBox.SelectedIndex + 1, true); //select next question in list so the teacher sees what question the students are anwering to.]
            }
        }

        //add a question to the list NEED TESTING IF THE QUESTION IS ADDED SO SIGNALR
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestionView view = new AddQuestionView(null);
            AddQuestionController controller = new AddQuestionController();
            controller.SetView(view);
            controller.SetQuestionList(this.controller.CurrentList);
            view.Show();//open view to add the question
            view.FormClosed += new FormClosedEventHandler(view_FormClosed);  

        }
        //when question added/canceled update list
        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentSelectedQuestion = QuestionsListBox.SelectedIndex; //remember current question
            this.controller.LoadList(this.controller.CurrentList);
            
        }
        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
