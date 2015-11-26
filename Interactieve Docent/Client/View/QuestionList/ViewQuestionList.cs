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

namespace Client.View.QuestionList
{
    public partial class ViewQuestionList : Form, IQuestionListView
    {
        private QuestionListController controller;

        public ViewQuestionList()
        {
            InitializeComponent();
            
        }

        public void setController(QuestionListController controller)
        {
            this.controller = controller;
        }

        public void loadList()
        {
            //listBoxQuestionLists.DataSource = QuestionList.getAll();
            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";
        }

        public Panel getPanel()
        {
            return panel;
        }
    }
}
