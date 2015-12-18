﻿using System;
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
        private BindingList<Model.PredefinedAnswer> CurrentAnswersList = new BindingList<Model.PredefinedAnswer>();
        private BindingList<Model.PredefinedAnswer> OldAnswersList = new BindingList<Model.PredefinedAnswer>();
        private BindingList<Model.PredefinedAnswer> RightAnswerList = new BindingList<Model.PredefinedAnswer>();
        private Boolean Edit;
        private Model.Question Question;
        
        public AddQuestionView(Model.Question question)
        {
            InitializeComponent();
            this.Question = question;

            btnSaveQuestion.Click += BtnSaveQuestion_Click;
            btnAddAnswer.Click += BtnAddAnswer_Click;
            btnDeleteAnswer.Click += BtnDeleteAnswer_Click;
            btnQuit.Click += BtnQuit_Click;

            answersListBox.DisplayMember = "Text";
            rightAnswerComboBox.DisplayMember = "Text";

            answerField.PreviewKeyDown += AnswerField_PreviewKeyDown;
            answersListBox.DataSource = CurrentAnswersList;
            rightAnswerComboBox.DataSource = RightAnswerList;

            if (question != null)
            {
                EditQuestion(question);
                labelTitle.Text = "Vraag wijzigen ";
                Edit = true;
            }
            else
            {
                labelTitle.Text = "Nieuwe vraag";
                Edit = false;
            }
        }

        private void EditQuestion(Model.Question question)
        {
            questionField.Text = question.Text;
            timeField.Value = question.Time;
            pointsField.Value = question.Points;
            //question.PredefinedAnswers = OldAnswersList.ToList();

            foreach(Model.PredefinedAnswer pa in question.PredefinedAnswers)
            {
                OldAnswersList.Add(pa);
                CurrentAnswersList.Add(pa);
                RightAnswerList.Add(pa);
            }
        }

        public void ClearAllFields()
        {
            questionField.Text = "";
            timeField.Value = 0;
            pointsField.Value = 0;
            CurrentAnswersList.Clear();
            answersListBox.DataSource = CurrentAnswersList;
            RightAnswerList.Clear();
            rightAnswerComboBox.DataSource = RightAnswerList;
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
            CurrentAnswersList.Remove(GetSelectedAnswer());
            RightAnswerList.Remove(GetSelectedAnswer());
        }

        //Add answer to AnswersList
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            //Remove all whitespaces at beginning and end of the string
            String answer = answerField.Text;
            answer = answer.Trim();

            if (answer != "" && CurrentAnswersList.ToList().Find(x => x.Text == answer) == null)
            {
                Model.PredefinedAnswer pa = new Model.PredefinedAnswer() { Text = answer };
                CurrentAnswersList.Add(pa);
                RightAnswerList.Add(pa);
                this.answerField.Text = "";
                this.answerField.Focus();
            }                 
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Antwoordveld niet ingevuld of het antwoord bestaat al.";
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
                    
                    if (Edit)
                    {
                        Dictionary<string, object> iDictionary2 = iDictionary;
                        iDictionary2.Add("Id", Question.Id);
                        this.Controller.UpdateQuestion(iDictionary2);
                    }
                    else
                    {
                        this.Controller.SaveQuestion(iDictionary);
                    }
                }
            }
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "U heeft nog niet alle velden ingevuld.";
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
            succes.getLabelSucces().Text = "De vraag is succesvol opgeslagen.";
            succes.ShowDialog();
        }

        public void ShowSaveResult(Model.Question instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created && instance != null)
            {
                this.Controller.SavePredefinedAnswers(CurrentAnswersList.ToList(), instance, false);
            }
            else
            {
                this.ShowSaveFailed();
            }
        }

        private void AddQuestionView_Load(object sender, EventArgs e)
        {
            //this.questionField.Focus();
        }

        public void ShowUpdateResult(Model.Question instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.NoContent && instance != null)
            {
                this.Controller.DeletePredefinedAnswers(OldAnswersList.ToList(), instance);
            }
            else
            {
                this.ShowSaveFailed();
            }
        }

        public void ShowDeleteAnswersResult(Model.Question instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && instance != null)
            {
                this.Controller.SavePredefinedAnswers(CurrentAnswersList.ToList(), instance, true);
            }
            else
            {
                this.ShowSaveFailed();
            }
        }
    }
}
