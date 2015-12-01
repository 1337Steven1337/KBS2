using Client.View.Question;
using System.Windows.Forms;
using Client.Factory;
using System;
using Client.Model;
using System.ComponentModel;
using Client.View.PanelLayout;
using Client.Event;
using System.Collections.Generic;

namespace Client.Controller
{
    public class QuestionController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(Question message);
        #endregion

        #region Declare Events
        public event SelectedIndexChanged selectedIndexChanged;
        #endregion

        #region Properties
        private int listId;
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
            this.questionView.getCustomPanel().rightBottomButton.Click += new System.EventHandler(deleteQuestion);

            this.questionView.getCustomPanel().leftBottomButton.Text = "Nieuwe vraag";
            this.questionView.getCustomPanel().rightBottomButton.Text = "Verwijder vraag";

            threeColTable.Controls.Add(this.questionView.getCustomPanel().getPanel(), 1, 0);

            this.listBoxQuestion.SelectedIndexChanged += new System.EventHandler(ListBoxQuestion_SelectedIndexChanged);

        }

        public QuestionController(IAddQuestionView addQuestionView, TableLayoutPanel threeColTable, int listId)
        {
            this.listId = listId;
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


            

            //customPanel.middleRow.Controls.Add(listBoxQuestion);
            //customPanel.rightBottomButton.Text = "Delete";
            //customPanel.rightBottomButton.Click += new System.EventHandler(deleteQuestion);

            threeColTable.Controls.Add(addQuestionView.getCustomPanel().getPanel(), 2, 0);
        }
        #endregion

        #region Events
        private void ListBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged((Question)this.listBoxQuestion.SelectedItem);
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

        public void fillList(List<Question> list)
        {
            this.Questions.Clear();
            List<Question> filtered = list.FindAll(x => x.List_Id == this.questionView.listId);

            foreach (Question q in filtered)
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
            factory.findAll(threeColTable, this.fillList);
        }

        private void add_questionHandler(object sender, System.EventArgs e)
        {
            ViewAddQuestion addQuestionView = new ViewAddQuestion();
            QuestionController controller = new QuestionController(addQuestionView, threeColTable, questionView.listId); 
        }

        private void processAdd(Question q)
        {
            this.Questions.Add(q);
        }

        private void saveQuestionHandler(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Text = addQuestionView.getQuestionField().Text;
            q.Time = (int)addQuestionView.getTimeField().Value;
            q.Points = (int)addQuestionView.getPointsField().Value;
            q.List_Id = this.listId;
            
            factory.saveAsync(q, null);

            processAdd(q);

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
