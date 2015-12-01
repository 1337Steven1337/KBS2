using Client.View.Question;
using System.Windows.Forms;
using Client.Factory;
using System;
using Client.Model;
using System.ComponentModel;
using Client.View.PanelLayout;
using Client.Event;

namespace Client.Controller
{
    public class QuestionController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(QuestionControllerSelectedIndexChanged message);
        #endregion

        #region Declare Events
        public event SelectedIndexChanged selectedIndexChanged;
        #endregion

        private TableLayoutPanel threeColTable;
        private ListBox listBoxQuestion;
        private CustomPanel customPanel;
        private QuestionFactory factory = new QuestionFactory();
        public BindingList<Question> Questions = new BindingList<Question>();
        private IQuestionView questionView;
        private IAddQuestionView addQuestionView;
        #endregion

        #region Constructor
        public QuestionController(IQuestionView questionView, TableLayoutPanel threeColTable)
        {

            this.threeColTable = threeColTable;

            this.questionView = questionView;
            this.questionView.setController(this);
            this.listBoxQuestion = this.questionView.getListBox();
            this.customPanel = this.questionView.getCustomPanel();

            this.questionView.getCustomPanel().middleRow.Controls.Add(questionView.getListBox());
            this.questionView.getCustomPanel().leftBottomButton.Click += add_questionHandler;

            threeColTable.Controls.Add(this.questionView.getCustomPanel().getPanel(), 1, 0);

            this.listBoxQuestion.SelectedIndexChanged += new System.EventHandler(ListBoxQuestion_SelectedIndexChanged);

        }

        public QuestionController(IAddQuestionView addQuestionView, TableLayoutPanel threeColTable)
        {
            this.threeColTable = threeColTable;

            this.addQuestionView = addQuestionView;
            this.addQuestionView.setController(this);

            addQuestionView.getCustomPanel().middleRow.Controls.Add(addQuestionView.getTable());
            addQuestionView.getCustomPanel().title.Text = "Nieuwe vraag";

            addQuestionView.getCustomPanel().bottomRow.Controls.Clear();
            addQuestionView.getCustomPanel().bottomRow.Controls.Add(addQuestionView.getCustomPanel().leftBottomButton);

            addQuestionView.getCustomPanel().leftBottomButton.Click += saveQuestionHandler;
            addQuestionView.getAddAnswerBtn().Click += addAnswerToListBox;
            addQuestionView.getRemoveAnswerBtn().Click += removeAnswerFromListBox;

            customPanel.middleRow.Controls.Add(listBoxQuestion);
            customPanel.rightBottomButton.Text = "Delete";
            customPanel.rightBottomButton.Click += new System.EventHandler(deleteQuestion);

            threeColTable.Controls.Add(addQuestionView.getCustomPanel().getPanel(), 2, 0);
        }
        #endregion

        #region Events
        private void ListBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged(new QuestionControllerSelectedIndexChanged((Question)this.listBoxQuestion.SelectedItem));
            }
        }
        #endregion

        #region Methodes
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
                factory.delete(q, this.questionView.getListBox(), processDelete);
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
            questionView.listId = listId;
            factory.findAll(threeColTable, this.questionView.fillList);
        }

        private void add_questionHandler(object sender, System.EventArgs e)
        {
            ViewAddQuestion addQuestionView = new ViewAddQuestion();
            QuestionController controller = new QuestionController(addQuestionView, threeColTable); 
        }

        private void saveQuestionHandler(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Text = addQuestionView.getQuestionField().Text;
            q.Time = (int)addQuestionView.getTimeField().Value;
            q.Points = (int)addQuestionView.getPointsField().Value;
            q.List_Id = questionView.listId; //QuestionView.ListId krijgt 0, moet nog gefixt worden (dus het listId)
            
            factory.saveAsync(q, null);

            //PredefinedAnswer pa;
            //foreach (String answer in panelRight.predefinedAnswersList.Items)
            //{
            //    pa = new PredefinedAnswer() { Text = answer };
            //    pa.save(q.Id);
            //}

            ////reload question list
            //panelMiddle.loadQuestionList(listId);
        }

        private void addAnswerToListBox(object sender, EventArgs e)
        {
            //Check if field is not empty
            if (addQuestionView.getAnswerField().Text.Length != 0)
            {
                Boolean listExists = false;

                foreach (var answer in addQuestionView.getAnswersListBox().Items)
                {
                    if (answer.Equals(addQuestionView.getAnswerField().Text))
                    {
                        listExists = true;
                    }
                }

                if (!listExists)
                {
                    addQuestionView.getAnswersListBox().Items.Add(addQuestionView.getAnswerField().Text);
                }
            }
        }

        private void removeAnswerFromListBox(object sender, EventArgs e)
        {
            if (addQuestionView.getAnswersListBox().SelectedIndex >= 0)
            {
                addQuestionView.getAnswersListBox().Items.Remove(addQuestionView.getAnswersListBox().SelectedItem);
            }

        }
        #endregion
    }
}
