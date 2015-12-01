using Client.View.Question;
using System.Windows.Forms;
using Client.Factory;
using Client.Model;
using System;

namespace Client.Controller
{
    public class QuestionController
    {
        private IQuestionView questionView;
        private IAddQuestionView addQuestionView;
        private TableLayoutPanel threeColTable;
        private QuestionFactory factory = new QuestionFactory();

        public QuestionController(IQuestionView questionView, TableLayoutPanel threeColTable)
        {
            this.threeColTable = threeColTable;

            this.questionView = questionView;
            this.questionView.setController(this);

            questionView.getCustomPanel().middleRow.Controls.Add(questionView.getListBox());
            questionView.getCustomPanel().leftBottomButton.Click += add_questionHandler;

            threeColTable.Controls.Add(questionView.getCustomPanel().getPanel(), 1, 0);           
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

            threeColTable.Controls.Add(addQuestionView.getCustomPanel().getPanel(), 2, 0);
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
            
            factory.save(q, null);

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
    }
}
