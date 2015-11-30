using Client.View.Question;
using Client.View.PanelLayout;
using System.Windows.Forms;
using Client.Factory;
using Client.Event;
using Client.Model;

namespace Client.Controller
{
    public class QuestionController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(QuestionControllerSelectedIndexChanged message);
        #endregion

        #region Events
        public event SelectedIndexChanged selectedIndexChanged;
        #endregion

        private IQuestionView view;
        private TableLayoutPanel mainTable, threeColTable;
        private ListBox listBoxQuestion;
        private CustomPanel customPanel;
        private QuestionFactory factory = new QuestionFactory();

        public QuestionController(IQuestionView view, TableLayoutPanel mainTable, TableLayoutPanel threeColTable)
        {
            this.mainTable = mainTable;
            this.threeColTable = threeColTable;
            this.listBoxQuestion = view.getListBox();
            this.customPanel = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);

            this.listBoxQuestion.SelectedIndexChanged += ListBoxQuestion_SelectedIndexChanged;

            customPanel.middleRow.Controls.Add(listBoxQuestion);

            threeColTable.Controls.Add(customPanel.getPanel(), 1, 0);
        }

        private void ListBoxQuestion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged(new QuestionControllerSelectedIndexChanged((Question)this.listBoxQuestion.SelectedItem));
            }
        }

        public void loadQuestions(int listId)
        {
            view.listId = listId;
            factory.findAll(mainTable, this.view.fillList);
        }
    }
}
