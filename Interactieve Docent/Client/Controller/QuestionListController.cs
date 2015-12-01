using Client.Factory;
using Client.View.QuestionList;
using System.Windows.Forms;
using Client.View.Question;
using Client.Model;
using Client.View.PanelLayout;

namespace Client.Controller
{
    public class QuestionListController
    {
        private IQuestionListView view;
        private TableLayoutPanel threeColTable;
        private ListBox listBoxQuestionLists;
        private CustomPanel customPanelQuestionList;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;

        public QuestionListController(IQuestionListView view, TableLayoutPanel threeColTable, QuestionController questionController)
        {
            this.threeColTable = threeColTable;
            this.listBoxQuestionLists = view.getListBox();
            this.customPanelQuestionList = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);
            this.questionController = questionController;

            customPanelQuestionList.middleRow.Controls.Add(listBoxQuestionLists);
            customPanelQuestionList.title.Text = "VragenLijsten";

            threeColTable.Controls.Add(customPanelQuestionList.getPanel(), 0, 0);
            
            loadLists();            
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        private void loadLists()
        {
            factory.findAll(threeColTable, this.view.fillList);
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            questionController.loadQuestions((int)listBoxQuestionLists.SelectedValue);
        }
    }
}
