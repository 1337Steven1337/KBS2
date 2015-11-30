using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.View.PanelLayout;
using Client.Factory;

namespace Client.View.QuestionList
{
    public partial class  ViewQuestionList : Form, IQuestionListView
    {
        private QuestionListController controller;
        private CustomPanel customPanel;

        public ViewQuestionList()
        {
            InitializeComponent();
            customPanel = new CustomPanel();

        }

        public void setController(QuestionListController controller)
        {
            this.controller = controller;
        }

        public void fillList(List<Model.QuestionList> lists)
        {
            listBoxQuestionLists.DataSource = lists;
            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id2";
        }

        public ListBox getListBox()
        {
            return listBoxQuestionLists;
        }
        
        public CustomPanel getCustomPanel()
        {
            return customPanel;
        }   
    }
}
