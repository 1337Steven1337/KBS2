using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using System.Linq;
using Client.Model;
using Client.Service.Thread;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView
    {
        public delegate void AddQuestionClickedDelegate();
        public event AddQuestionClickedDelegate AddQuestionClicked;

        private QuestionController controller;

        public ViewQuestion()
        {
            InitializeComponent();

            listBoxQuestions.DisplayMember = "Text";
            listBoxQuestions.ValueMember = "Id";

            listBoxQuestions.SelectedIndexChanged += ListBoxQuestion_SelectedIndexChanged;
            btnDeleteQuestion.Click += deleteQuestion;
            btnAddQuestion.Click += loadAddQuestion;
            btnShowResults.Click += showResults;
        }

        public void SetTable<TablePanelLayout>(TablePanelLayout tableThreeColls)
        {
            //controller.setTable(tableThreeColls);
        }

        private void showResults(object sender, EventArgs e)
        {
            this.controller.showResults();
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
            this.controller.deleteQuestion();
        }

        private void ListBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controller.ListBoxQuestion_SelectedIndexChanged(listBoxQuestions.SelectedItem);

        }
        public void setController(QuestionController controller)
        {
            this.controller = controller;
            listBoxQuestions.DataSource = this.controller.Questions;
        }

        public List<Model.Question> getQuestionList()
        {
            return this.controller.Questions.ToList();
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

        public IControlHandler getHandler()
        {
            return new ControlHandler(this.listBoxQuestions);
        }
    }
}
