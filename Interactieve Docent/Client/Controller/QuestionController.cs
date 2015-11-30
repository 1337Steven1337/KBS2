using Client.View.Question;
using Client.View.PanelLayout;
using System.Windows.Forms;
using Client.Factory;
using System;
using Client.Model;
using System.ComponentModel;

namespace Client.Controller
{
    public class QuestionController
    {
        private IQuestionView view;
        private TableLayoutPanel mainTable, threeColTable;
        private ListBox listBoxQuestion;
        private CustomPanel customPanel;
        private QuestionFactory factory = new QuestionFactory();
        public BindingList<Question> Questions = new BindingList<Question>();

        public QuestionController(IQuestionView view, TableLayoutPanel mainTable, TableLayoutPanel threeColTable)
        {
            this.mainTable = mainTable;
            this.threeColTable = threeColTable;
            this.listBoxQuestion = view.getListBox();
            this.customPanel = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);

            customPanel.middleRow.Controls.Add(listBoxQuestion);
            customPanel.rightBottomButton.Text = "Delete";
            customPanel.rightBottomButton.Click += new System.EventHandler(deleteQuestion);

            threeColTable.Controls.Add(customPanel.getPanel(), 1, 0);
        }

        public void deleteQuestion(object sender, EventArgs e)
        {
            ViewDeleteQuestion dlg = new ViewDeleteQuestion();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(listBoxQuestion.SelectedItem.ToString());
            dlg.ShowDialog();

            if (dlg.valid)
            {
                int id = (int)listBoxQuestion.SelectedValue;
                Question q = new Question();
                q.Id = id;
                factory.delete(q, this.view.getListBox(), processDelete);
            }
        }

        public void fillList(QuestionList list)
        {
            foreach (Question q in list)
            {
                this.Questions.Add(q);
            }
        }

        public void processDelete(Question q)
        {
            int i;
            for (i = 0; i < this.Questions.Count; i++)
            {
                if (this.Questions[i].Id == q.Id)
                {
                    break;
                }
            }

            this.Questions.RemoveAt(i);
        }

        public void loadQuestions(int listId)
        {
            view.listId = listId;
            factory.findAll(mainTable, this.view.fillList);
        }
    }
}
