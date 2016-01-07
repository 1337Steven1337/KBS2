using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.Controller.OpenQuestion;
using Client.View.Dialogs;
using MetroFramework.Forms;

namespace Client.View.OpenQuestion
{
    public partial class AddOpenQuestionView : MetroForm, IAddView<Model.OpenQuestion>
    {
        private AddOpenQuestionController Controller { get; set; }

        public AddOpenQuestionView()
        {
            InitializeComponent();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.QuestionTextBox);
        }

        public PredefinedAnswer GetSelectedAnswer()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.Controller = (AddOpenQuestionController)controller;
        }

        public void ShowSaveFailed()
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Het opslaan is mislukt! Probeer het opnieuw.";

            BackgroundDialogView background = new BackgroundDialogView(this, failed);
        }

        public void ShowSaveResult(Model.OpenQuestion instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created)
            {
                this.ShowSaveSucceed();
            }
            else
            {
                this.ShowSaveFailed();
            }
        }

        public void ShowSaveSucceed()
        {
            SuccesDialogView succes = new SuccesDialogView();
            succes.getLabelSucces().Text = "De vraag is nu zichtbaar voor de studenten.";

            BackgroundDialogView background = new BackgroundDialogView(this, succes);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Model.OpenQuestion question = new Model.OpenQuestion();
            question.Text = QuestionTextBox.Text;

            this.Controller.Save(question);
        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = (QuestionTextBox.Text != null && QuestionTextBox.Text.Length > 0);
        }

        public void ShowUpdateResult(Model.OpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteAnswersResult(Model.OpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ClearAllFields()
        {
            throw new NotImplementedException();
        }
    }
}
