using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View.Main;
using Client.Controller.Question;
using System.Net;
using Client.View.Dialogs;
using System.ComponentModel;
using System.Linq;

namespace Client.View.Question
{
    public partial class AddQuestionView : Form, IAddView<Model.Question>
    {
        private AddQuestionController Controller;
        private BindingList<Model.PredefinedAnswer> AnswersList = new BindingList<Model.PredefinedAnswer>();

        public AddQuestionView()
        {
            InitializeComponent();

            btnSaveQuestion.Click += BtnSaveQuestion_Click;
            btnAddAnswer.Click += BtnAddAnswer_Click;
            btnDeleteAnswer.Click += BtnDeleteAnswer_Click;
            btnQuit.Click += BtnQuit_Click;

            answersListBox.DisplayMember = "Text";
            rightAnswerComboBox.DisplayMember = "Text";

            answerField.PreviewKeyDown += AnswerField_PreviewKeyDown;
            answersListBox.DataSource = AnswersList;            
            rightAnswerComboBox.DataSource = AnswersList;
        }

        private void AnswerField_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnAddAnswer_Click(sender, e);
            }
        }

        //Close the third panel, Which contains the addquestion fields
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Controller.InvokeRemoveQuestionPanel();
        }

        //Delete selected answer from AnswersList
        private void BtnDeleteAnswer_Click(object sender, EventArgs e)
        {
            AnswersList.Remove(GetSelectedAnswer());
        }

        //Add answer to AnswersList
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            //Remove all whitespaces at beginning and end of the string
            String answer = answerField.Text;
            answer = answer.Trim();

            if (answer != "" && AnswersList.ToList().Find(x => x.Text == answer) == null)
            {
                Model.PredefinedAnswer pa = new Model.PredefinedAnswer() { Text = answer };
                AnswersList.Add(pa);
                answerField.Text = "";
            }                 
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Antwoordveld niet ingevuld of het antwoord bestaat al!";
                failed.ShowDialog();
            }
        }

        private void BtnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u de vraag wilt opslaan?";
                dr = confirm.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Dictionary<string, object> iDictionary = new Dictionary<string, object>();
                    iDictionary.Add("Text", questionField.Text.Trim());
                    iDictionary.Add("Points", pointsField.Value);
                    iDictionary.Add("Time", timeField.Value);
                    iDictionary.Add("PredefinedAnswerCount", this.answersListBox.Items.Count);

                    this.Controller.SaveQuestion(iDictionary);
                }
            }
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "U heeft nog niet alle velden ingevuld!";
                failed.ShowDialog();
            }
        }

        //Validate all inputfields
        private Boolean ValidateFields()
        {
            int Time = -1;
            int Points = -1;

            try
            {
                Time = Convert.ToInt32(timeField.Value);
                Points = Convert.ToInt32(pointsField.Value);
            }
            catch(Exception)
            {

            }

            //return true or false
            return (Time > 0 && Points > 0 && questionField.Text != "" && answersListBox.Items.Count > 0);
        }

        //Add view to mainTable
        public void AddToParent(IView parent)
        {
            MainView main = (MainView)parent;

            main.AddTablePanel(this.mainTablePanel,3);
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.answersListBox);
        }

        public void SetController(IController controller)
        {
            this.Controller = (AddQuestionController)controller;
        }

        //Get the Selelecteditem from Listbox
        public Model.PredefinedAnswer GetSelectedAnswer()
        {
            return (Model.PredefinedAnswer)this.answersListBox.SelectedItem;
        }

        public void ShowSaveFailed()
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Het opslaan is mislukt! Probeer het opnieuw.";
            failed.ShowDialog();
        }

        public void ShowSaveSucceed()
        {
            SuccesDialogView succes = new SuccesDialogView();
            succes.getLabelSucces().Text = "De vraag is succesvol opgeslagen!";
            succes.ShowDialog();
        }

        public void ShowSaveResult(Model.Question instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created && instance != null)
            {
                this.Controller.SavePredefinedAnswers(AnswersList.ToList(), instance);
            }
            else
            {
                this.ShowSaveFailed();
            }
        }        
    }
}
