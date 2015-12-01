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
        private CustomPanel customPanel;

        public int listId { get; set;}

        public ViewQuestion()
        {
            InitializeComponent();
            customPanel = new CustomPanel();

            listBoxQuestion.DisplayMember = "Text";
            listBoxQuestion.ValueMember = "Id";            
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
            listBoxQuestion.DataSource = this.controller.Questions;
        }

        public ListBox getListBox()
        {
            return listBoxQuestion;
        }

        public CustomPanel getCustomPanel()
        {
            return customPanel;
        }

        public void fillList(List<Model.Question> list)
        {
            listBoxQuestion.DisplayMember = "Text";
            listBoxQuestion.ValueMember = "Id";
            listBoxQuestion.DataSource = list.FindAll(x => x.List_Id == listId);
        }
    }
}
