using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.View.PanelLayout;
using Client.Model;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView
    {
        private QuestionController controller;

        public ViewQuestion()
        {
            InitializeComponent();

            listBoxQuestions.DisplayMember = "Text";
            listBoxQuestions.ValueMember = "Id";            
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
            listBoxQuestions.DataSource = this.controller.Questions;
        }

        public ListBox getListBoxQuestions()
        {
            return listBoxQuestions;
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
