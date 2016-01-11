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
using MetroFramework.Forms;
using Client.Factory;

namespace Client.View.Teacher
{
    public partial class TeacherEnvironmentView : MetroForm, IView
    {
        private TeacherEnvironmentController controller;
        private DiagramController DiagramController;
        public Model.Question CurrentQuestion;
        public int CurrentSelectedQuestion; //indicates which index is selected

        public BindingList<Model.Question> Questions = new BindingList<Model.Question>();

        public TeacherEnvironmentView() {

        }
        public TeacherEnvironmentView(Model.QuestionList list)
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            this.Text = "Vragenlijst: " + list.Name;

            this.QuestionsListBox.DisplayMember = "Text";
            this.QuestionsListBox.ValueMember = "Id";
            this.QuestionsListBox.DataSource = this.Questions;

            DiagramView diagramView = new DiagramView();
            this.DiagramController = new DiagramController(diagramView);

            AddQuestionView addQuestionView = new AddQuestionView(null);
            AddQuestionController addQuestionController = new AddQuestionController();
            addQuestionController.SetView(addQuestionView);
            addQuestionController.SetQuestionList(list);

            //use the event, to close the docentform when clicked on Quit
            addQuestionController.RemoveAddQuestionPanel += CloseForm;
            addQuestionController.QuestionSavedSucces += QuestionAdded;

            this.tableLeft.Controls.Add(diagramView.getTable(), 0, 0);
            this.tableWrapper.Controls.Add(addQuestionView.getTable(), 1, 0);           
        }

        private void CloseForm(bool resizeTable)
        {
            this.Close();
        }

        private void QuestionAdded()
        {
            this.Invoke((Action)delegate () { CurrentSelectedQuestion = QuestionsListBox.SelectedIndex; /*remember current question*/ });
            this.Invoke((Action)delegate () { this.controller.LoadList(this.controller.CurrentList); });
        }

        public Model.Question GetCurrentQuestion()
        {
            return (Model.Question)QuestionsListBox.SelectedItem;
        }

        public void UpdateResultsDiagram()
        {
            this.DiagramController.SetQuestion(GetCurrentQuestion());
        }

        //fill questionslistbox with the previous selected list
        public void FillList(List<Model.Question> list)
        {
            this.Questions.Clear();
        
            foreach (Model.Question question in list)
            {
                this.Questions.Add(question);
            }

            QuestionsListBox.SelectedIndex = CurrentSelectedQuestion;
            UpdateResultsDiagram();
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
            this.controller = (TeacherEnvironmentController)controller;
        }

        //the students go to the next question
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().GoToNextQuestionOnClick(Properties.Settings.Default.Session_Id); //go to next question
            int max = QuestionsListBox.Items.Count - 1; //can't go over the current amount of questions

            if (QuestionsListBox.SelectedIndex != max) { 
                QuestionsListBox.SetSelected((int)QuestionsListBox.SelectedIndex + 1, true); //select next question in list so the teacher sees what question the students are anwering to.]
            }

            UpdateResultsDiagram();
        }

        private void QuitQuestionList_Click(object sender, EventArgs e)
        {

        }
    }
}
