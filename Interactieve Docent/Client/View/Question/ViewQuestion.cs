using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView
    {
        private QuestionController controller;

        public ViewQuestion()
        {
            InitializeComponent();
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }

        public Panel getPanel()
        {
            return panel;
        }

        public void fillList(List<Model.Question> list)
        {
            listBoxQuestion.DataSource = list;
            listBoxQuestion.DisplayMember = "Text";
            listBoxQuestion.ValueMember = "Id";
        }
    }
}
