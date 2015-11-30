using Client.View.Question;
using Client.View.PanelLayout;
using System.Windows.Forms;
using Client.Factory;

namespace Client.Controller
{
    public class QuestionController
    {
        private IQuestionView view;
        private TableLayoutPanel mainTable, threeColTable;
        private ListBox listBox;
        private CustomPanel customPanel;
        private QuestionFactory factory = new QuestionFactory();

        public QuestionController(IQuestionView view, TableLayoutPanel mainTable, TableLayoutPanel threeColTable)
        {
            this.mainTable = mainTable;
            this.threeColTable = threeColTable;
            this.listBox = view.getListBox();
            this.customPanel = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);

            customPanel.middleRow.Controls.Add(listBox);

            threeColTable.Controls.Add(customPanel.getPanel(), 1, 0);
        }

        public void loadQuestions(int listId)
        {
            view.listId = listId;
            factory.findAll(mainTable, this.view.fillList);
        }
    }
}
