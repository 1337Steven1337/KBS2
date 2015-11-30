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
        private TableLayoutPanel mainTable, threeColTable;
        private ListBox listBoxQuestionLists;
        private CustomPanel customPanel;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;

        public QuestionListController(IQuestionListView view, TableLayoutPanel mainTable, TableLayoutPanel threeColTable, QuestionController questionController)
        {
            this.mainTable = mainTable;
            this.threeColTable = threeColTable;
            this.listBoxQuestionLists = view.getListBox();
            this.customPanel = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);
            this.questionController = questionController;

            customPanel.middleRow.Controls.Add(listBoxQuestionLists);
            customPanel.title.Text = "VragenLijsten";

            threeColTable.Controls.Add(customPanel.getPanel(), 0, 0);
            mainTable.Controls.Add(threeColTable, 1, 0);

            loadLists();
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        private void loadLists()
        {
            factory.findAll(mainTable, this.view.fillList);
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            questionController.loadQuestions((int)listBoxQuestionLists.SelectedValue);
        }
    }
}
