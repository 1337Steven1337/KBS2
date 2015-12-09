using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.View.Main;
using System.ComponentModel;
using Client.Controller.Question;
using Client.Model;
using System.Net;

namespace Client.View.Question
{
    public partial class ListQuestionView : Form, IListView<Model.Question>
    {
        #region Delegates
        public delegate void AddQuestionClickedDelegate(Model.QuestionList list);
        #endregion

        #region Events
        public event AddQuestionClickedDelegate AddQuestionClicked;
        #endregion

        #region Properties
        public BindingList<Model.Question> Questions = new BindingList<Model.Question>();
        #endregion

        #region Instances
        private ListQuestionController Controller { get; set; }
        #endregion

        #region Constructors
        public ListQuestionView()
        {
            InitializeComponent();

            listBoxQuestions.DisplayMember = "Text";
            listBoxQuestions.ValueMember = "Id";

            listBoxQuestions.DataSource = this.Questions;

            listBoxQuestions.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            btnAddQuestion.Click += BtnAddQuestion_Click;
        }
        #endregion

        #region Event handlers
        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            if (this.AddQuestionClicked != null)
            {
                this.AddQuestionClicked(this.Controller.CurrentList);
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods
        public void FillList(List<Model.Question> list)
        {
            this.Questions.Clear();

            foreach (Model.Question question in list)
            {
                this.Questions.Add(question);
            }

            btnAddQuestion.Enabled = (this.Controller.CurrentList != null);
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.listBoxQuestions);
        }

        public void AddToParent(IView parent)
        {
            MainView main = (MainView)parent;
            main.AddTablePanel(this.mainTablePanel, 2);
        }

        public void SetController(IController controller)
        {
            this.Controller = (ListQuestionController)controller;
        }

        public Model.Question getSelectedItem()
        {
            return (Model.Question)this.listBoxQuestions.SelectedItem;
        }

        public void AddItem(Model.Question question)
        {
            Questions.Add(question);
        }

        public void ShowDeleteResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Model.Question item)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
