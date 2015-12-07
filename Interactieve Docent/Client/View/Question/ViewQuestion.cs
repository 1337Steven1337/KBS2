using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.View.Main;
using System.ComponentModel;
using Client.Controller.Question;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView<Model.Question>
    {
        #region Delegates
        public delegate void AddQuestionClickedDelegate();
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
        public ViewQuestion()
        {
            InitializeComponent();

            listBoxQuestions.DisplayMember = "Text";
            listBoxQuestions.ValueMember = "Id";

            listBoxQuestions.DataSource = this.Questions;

            listBoxQuestions.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            btnDeleteQuestion.Click += deleteQuestion;
            btnAddQuestion.Click += BtnAddQuestion_Click;
            btnShowResults.Click += showResults;
        }
        #endregion

        #region Event handlers
        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            if (this.AddQuestionClicked != null)
            {
                this.AddQuestionClicked();
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
            ViewMain main = (ViewMain)parent;
            main.AddTablePanel(this.mainTablePanel, 1);
        }

        public void SetController(IController controller)
        {
            this.Controller = (ListQuestionController)controller;
        }

        public Model.Question getSelectedItem()
        {
            return (Model.Question)this.listBoxQuestions.SelectedItem;
        }
        #endregion

        public void SetTable<TablePanelLayout>(TablePanelLayout tableThreeColls)
        {
            //controller.setTable(tableThreeColls);
        }

        private void showResults(object sender, EventArgs e)
        {
            //this.controller.showResults();
        }

        private void loadAddQuestion(object sender, EventArgs e)
        {
            //this.controller.loadAddQuestion();

            if(this.AddQuestionClicked != null)
            {
                this.AddQuestionClicked();
            }
        }

        private void deleteQuestion(object sender, EventArgs e)
        {
            //this.controller.deleteQuestion();
        }

        /**private void ListBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Controller != null)
            {
                this.Controller.ListBoxQuestion_SelectedIndexChanged(listBoxQuestions.SelectedItem);
            }

        }**/
        public void setController(QuestionController controller)
        {
            //this.controller = controller;
            //listBoxQuestions.DataSource = this.controller.Questions;
        }

        public List<Model.Question> getQuestionList()
        {
            //return this.controller.Questions.ToList();
            return null;
        }

        public Button getBtnAddQuestion()
        {
            return btnAddQuestion;
        }

        public Button getBtnDeleteQuestion()
        {
            return btnDeleteQuestion;
        }

        public Button getBtnShowResults()
        {
            return btnShowResults;
        }

        public TableLayoutPanel getPanel()
        {
            return mainTablePanel;
        }
    }
}
