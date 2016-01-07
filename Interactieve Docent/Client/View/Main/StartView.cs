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
        private Model.Pincode Code;
        private ShowStartController Controller;

        public StartView()
        {
            InitializeComponent();
        }

        public string GetPassword()
        {
            return this.PasswordTextBox.Text;
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.CodeTextBox);
        }

        public void Continue()
        {
            this.CodeTextBox.Invoke((Action)(() => {
                this.Hide();
                this.StartStudentScreen(this.Code);
            }));

        }

        public void ShowPasswordResult(bool result)
        {
            if (!result)
            {
                LoginButton.Enabled = true;
                CodeTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;

                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Het wachtwoord is incorrect.";
                BackgroundDialogView background = new BackgroundDialogView(this, failed);
            }
        }

        public void ShowCodeResult(Model.Pincode instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK)
            {
                this.Code = instance;
            }
            else
            {
                LoginButton.Enabled = true;
                CodeTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;

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
            if (this.CodeTextBox.Text != null && this.CodeTextBox.Text.Length == 6 &&
                this.PasswordTextBox.Text != null && this.PasswordTextBox.Text.Length == 6)
            {
                LoginButton.Enabled = false;
                CodeTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;

                Controller.CheckCode(this.CodeTextBox.Text);
            }
        }

        private void StartStudentScreen(Model.Pincode pin)
        {        
            Client.Student.QuestionForm studentForm = new Client.Student.QuestionForm(pin.Id);
            studentForm.Show();
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = (CodeTextBox.Text != null && CodeTextBox.Text.Length == 6 && this.PasswordTextBox.Text != null && this.PasswordTextBox.Text.Length == 6);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = (CodeTextBox.Text != null && CodeTextBox.Text.Length == 6 && this.PasswordTextBox.Text != null && this.PasswordTextBox.Text.Length == 6);
        }
    }
}
