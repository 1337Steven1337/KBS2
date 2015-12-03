using Client.View.Question;
using Client.View.Diagram;
using System.Windows.Forms;
using Client.Factory;
using System;
using Client.Model;
using System.ComponentModel;
using Client.View.PanelLayout;
using System.Collections.Generic;

namespace Client.Controller
{
    public class QuestionController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(Question message);
        public delegate void LoadAddQuestion(object sender, EventArgs e);
        public delegate void QuitAddQuestion(object sender, EventArgs e);
        #endregion

        #region Declare Events
        public event SelectedIndexChanged selectedIndexChanged;
        public event LoadAddQuestion loadAddQuestion;
        public event QuitAddQuestion quitAddQuestion;
        #endregion

        #region Properties
        private QuestionFactory factory = new QuestionFactory();
        private PredefinedAnswerFactory factoryPA = new PredefinedAnswerFactory();
        public BindingList<Question> Questions = new BindingList<Question>();
        private IQuestionView questionView;
        private IAddQuestionView addQuestionView;
        private int listId { get; set; }
        #endregion

        #region Constructor
        public QuestionController(IQuestionView questionView)
        {
            this.questionView = questionView;
            this.questionView.setController(this);

            this.questionView.getBtnAddQuestion().Click += LoadAddQuestionHandler;
            this.questionView.getBtnShowResults().Click += ShowResultsHandler;
            this.questionView.getBtnDeleteQuestion().Click += new System.EventHandler(deleteQuestion);
            this.questionView.getListBoxQuestions().SelectedIndexChanged += new System.EventHandler(ListBoxQuestion_SelectedIndexChanged);
        }       
        #endregion

        #region Events
        private void ListBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged((Question)this.questionView.getListBoxQuestions().SelectedItem);
            }
        }
        #endregion

        #region Methodes
        public void clearAddQuestion()
        {
            addQuestionView.getQuestionField().ResetText();
            addQuestionView.getPointsField().ResetText();
            addQuestionView.getTimeField().ResetText();
            addQuestionView.getAnswersListBox().Items.Clear();
            addQuestionView.getRightAnswerComboBox().Items.Clear();
        }

        public TableLayoutPanel getAddQuestionPanel()
        {
            return addQuestionView.getPanel();
        }

        private void LoadAddQuestionHandler(object sender, System.EventArgs e)
        {
            addQuestionView = new ViewAddQuestion();
            addQuestionView.setController(this);

            addQuestionView.getBtnSaveQuestion().Click += saveQuestion;
            addQuestionView.getBtnQuit().Click += QuitAddQuestionHandler;
            addQuestionView.getBtnAddAnswer().Click += addAnswerToListBox;
            addQuestionView.getBtnDeleteAnswer().Click += removeAnswerFromListBox;

            loadAddQuestion.Invoke(sender, e);
        }

        private void saveQuestion(object sender, EventArgs e)
        {
            if (addQuestionView.getQuestionField().Text != "" && (int)addQuestionView.getTimeField().Value != 0 && addQuestionView.getPointsField().Value != 0 && addQuestionView.getRightAnswerComboBox().SelectedItem != null)
            {
                Question q = new Question();
                q.Text = addQuestionView.getQuestionField().Text;
                q.Time = (int)addQuestionView.getTimeField().Value;
                q.Points = (int)addQuestionView.getPointsField().Value;
                q.List_Id = this.listId;
                q.PredefinedAnswerCount = addQuestionView.getAnswersListBox().Items.Count;

                factory.save(q, addQuestionView.getAnswersListBox(), processAdd);
            }
            else
            {
                MessageBox.Show("Gelieve alle velden in te vullen!");
            }
        }

        private void QuitAddQuestionHandler(object sender, System.EventArgs e)
        {
            clearAddQuestion();
            quitAddQuestion.Invoke(sender, e);
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
                    addQuestionView.getRightAnswerComboBox().Items.Add(addQuestionView.getAnswerField().Text);
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

        public void deleteQuestion(object sender, EventArgs e)
        {
            ViewDeleteQuestion dlg = new ViewDeleteQuestion();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(questionView.getListBoxQuestions().SelectedItem.ToString());
            dlg.ShowDialog();

            if (dlg.valid)
            {
                int id = (int)questionView.getListBoxQuestions().SelectedValue;
                Question q = new Question();
                q.Id = id;
                factory.delete(q, this.questionView.getListBoxQuestions(), processDelete);
            }
        }

        private void ShowResultsHandler(object sender, EventArgs e)
        {
            ViewDiagram view = new ViewDiagram();
            DiagramController controller = new DiagramController(view, this);
        }

        public void fillList(List<Question> list)
        {
            this.Questions.Clear();
            List<Question> filtered = list.FindAll(x => x.List_Id == this.listId);

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
            this.listId = listId;
            //questionView.getCustomPanel().title.Text = "Vragen uit lijst: " + listName;
            factory.findAll(questionView.getListBoxQuestions(), this.fillList);
        }

        private void processAdd(Question q)
        {
            this.Questions.Add(q);

            string rightAnswer = (string)addQuestionView.getRightAnswerComboBox().SelectedItem;
            PredefinedAnswer pa;
            foreach (String answer in addQuestionView.getAnswersListBox().Items)
            {
                pa = new PredefinedAnswer() { Question_Id = q.Id, Text = answer };
                if (pa.Text == rightAnswer)
                {
                    pa.RightAnswer = true;
                }
                else
                {
                    pa.RightAnswer = false;
                }

                factoryPA.saveAsync(pa, null);
            }
        }
        #endregion
    }
}
