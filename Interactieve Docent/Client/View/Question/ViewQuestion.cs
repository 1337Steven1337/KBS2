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
        private CustomPanel customPanelQuestion;

        public int listId { get; set;}

        public ViewQuestion()
        {
            InitializeComponent();
            customPanelQuestion = new CustomPanel();            
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }

        public ListBox getListBox()
        {
            return listBoxQuestion;
        }

        public void fillList(List<Model.Question> list)
        {
            listBoxQuestion.DisplayMember = "Text";
            listBoxQuestion.ValueMember = "Id";
            listBoxQuestion.DataSource = list.FindAll(x => x.List_Id == listId);
        }

        public CustomPanel getCustomPanel()
        {
            return customPanelQuestion;
        }
    }
}
