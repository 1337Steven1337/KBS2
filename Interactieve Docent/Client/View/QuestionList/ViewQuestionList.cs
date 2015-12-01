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
using Client.Model;

namespace Client.View.QuestionList
{
    public partial class  ViewQuestionList : Form, IQuestionListView
    {
        private QuestionListController controller;
        private CustomPanel customPanelQuestionList;

        public ViewQuestionList()
        {
            InitializeComponent();
            customPanel = new CustomPanel();

            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";

            customPanelQuestionList = new CustomPanel();
        }

        public void setController(QuestionListController controller)
        {
            this.controller = controller;
            listBoxQuestionLists.DataSource = this.controller.QuestionLists;
        }


        public ListBox getListBox()
        {
            return listBoxQuestionLists;
        }
        
        public CustomPanel getCustomPanel()
        {
            return customPanelQuestionList;
        }   

        public void fillList(List<Model.QuestionList> lists)
        {
           //throw new NotImplementedException();
        }
    }
}
