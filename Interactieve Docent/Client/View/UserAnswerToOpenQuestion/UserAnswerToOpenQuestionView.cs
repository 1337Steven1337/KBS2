using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;

namespace Client.View.OpenQuestion
{
    public partial class UserAnswerToOpenQuestionView : Form, IResultView<Model.UserAnswerToOpenQuestion>
    {
        #region Instances
        private UserAnswerToOpenQuestionController Controller { get; set; }
        private BindingList<KeyValuePair<String, String>> list { get; set; }
        #endregion

        public UserAnswerToOpenQuestionView()
        {
            InitializeComponent();

            dataGridView1.Enabled = false;

            list = new BindingList<KeyValuePair<string, string>>();
            
            dataGridView1.DataSource = list;
            dataGridView1.TabStop = false;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
            dataGridView1.Columns[0].HeaderText = "Student";
            dataGridView1.Columns[1].HeaderText = "Antwoord";
            
            dataGridView1.CurrentCell = null;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.dataGridView1);
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.Controller = (UserAnswerToOpenQuestionController)controller;
        }

        public void FillList(List<Model.UserAnswerToOpenQuestion> list)
        {
            this.list.Clear();
            if (this.Controller.Question != null)
            {
                foreach (Model.UserAnswerToOpenQuestion answer in list)
                {
                    if (answer.Question_Id == this.Controller.Question.Id)
                    {
                        this.list.Add(new KeyValuePair<string, string>(answer.Student, answer.Answer));
                    }
                }
            }
            else
            {
                foreach (Model.UserAnswerToOpenQuestion answer in list)
                {
                    this.list.Add(new KeyValuePair<string, string>(answer.Student, answer.Answer));
                }
            }
        }

        public void Refresh(List<UserAnswerToOpenQuestion> answers, Model.OpenQuestion question)
        {
            setText(question.Text);
            FillList(answers);
        }

        public void setText(string text)
        {
            this.label1.Text = text;
        }

        private void UserAnswerToOpenQuestionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.detach();
        }
    }
}
