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
using Client.Factory;

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
            //list.Add(new KeyValuePair<string, string>("Piet", "Pizza"));
            //list.Add(new KeyValuePair<string, string>("Henk", "Shoarma met saus"));
            
            dataGridView1.DataSource = list;
            dataGridView1.TabStop = false;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
            dataGridView1.Columns[0].HeaderText = "Student";
            dataGridView1.Columns[1].HeaderText = "Antwoord";

            

            //Controller.LoadList();
            //list.Add(new KeyValuePair<string, string>("Gekke Freek", "Een klein beetje kruidenboter flink uitgesmeerd op een half doorbakken sneetje stokbrood"));
            
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
                        this.list.Add(new KeyValuePair<string, string>(answer.Question_Id.ToString(), answer.Answer));
                    }
                }
            }
            else
            {
                foreach (Model.UserAnswerToOpenQuestion answer in list)
                {
                    this.list.Add(new KeyValuePair<string, string>(answer.Question_Id.ToString(), answer.Answer));
                }
            }
        }

        public void ShowSaveQuestionListResult(UserAnswerToOpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionListResult(UserAnswerToOpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionResult(UserAnswerToOpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void AddItem(UserAnswerToOpenQuestion item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(UserAnswerToOpenQuestion item)
        {
            throw new NotImplementedException();
        }

        public Model.OpenQuestion getSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void Make(List<string> questions, string text)
        {
            throw new NotImplementedException();
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
