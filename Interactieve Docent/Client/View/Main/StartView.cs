using System;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.Controller.Main;
using System.Net;
using Client.View.Dialogs;
using Client.View.Question;
using Client.Controller.Question;
using Client.View.QuestionList;
using Client.Controller.QuestionList;
using Client.View.OpenQuestion;
using Client.Controller.OpenQuestion;
using Client.Student;

namespace Client.View.Main
{
    public partial class StartView : Form, IStartView
    {
        private ShowStartController Controller;

        public StartView()
        {
            InitializeComponent();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.CodeTextBox);
        }

        public void ShowCodeResult(Model.Pincode instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.OK)
            {
                this.Hide();
                this.StartStudentScreen(instance);
            }
            else
            {
                LoginButton.Enabled = true;
                CodeTextBox.Enabled = true;

                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "De code is incorrect.";
                BackgroundDialogView background = new BackgroundDialogView(this, failed);
            }
        }

        public void SetController(IController controller)
        {
            this.Controller = (ShowStartController)controller;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(this.CodeTextBox.Text != null && this.CodeTextBox.Text.Length == 6)
            {
                LoginButton.Enabled = false;
                CodeTextBox.Enabled = false;

                Controller.CheckCode(this.CodeTextBox.Text);
            }
        }

        private void StartStudentScreen(Model.Pincode pin)
        {        
            //ListQuestionListView viewQuestionList = new ListQuestionListView();
            //ListQuestionListController listQuestionListController = new ListQuestionListController(viewQuestionList);
            //maincontroller.AddController(listQuestionListController);

            //listQuestionListController.SelectedListChanged += questionController.LoadList;
            //listQuestionListController.Load();

            //view.ShowDialog();

            //UserAnswerToOpenQuestionView view = new UserAnswerToOpenQuestionView();
            //UserAnswerToOpenQuestionController controller = new UserAnswerToOpenQuestionController(view);
            //view.Show();

            AddOpenQuestionView view2 = new AddOpenQuestionView();
            AddOpenQuestionController controller2 = new AddOpenQuestionController(view2);
            view2.Show();

            Client.Student.QuestionForm studentForm = new Client.Student.QuestionForm(pin.Id);
            studentForm.Show();
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = (CodeTextBox.Text != null && CodeTextBox.Text.Length == 6);
        }
    }
}
