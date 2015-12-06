using System.Windows.Forms;
using Client.Controller;


namespace Client.View.QuestionList
{
    public partial class  ViewQuestionList : Form, IQuestionListView
    {
        private QuestionListController controller;
        public ViewQuestionList()
        {
            InitializeComponent();
            //Set which data from the items are to access in the listbox
            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";
        }

        public void setController(QuestionListController controller)
        {
            //Attach to controller
            this.controller = controller;
            listBoxQuestionLists.DataSource = this.controller.QuestionLists;
        }

        public ListBox getListBoxQuestionLists()
        {
            return listBoxQuestionLists;
        }       

        public Button getBtnAddQuestionList()
        {
            return btnAddQuestionList;
        }
        
        public Button getBtnDeleteQuestionList()
        {
            return btnDeleteQuestionList;
        }

        public TableLayoutPanel getPanel()
        {
            return mainTablePanel;
        }
    }
}
