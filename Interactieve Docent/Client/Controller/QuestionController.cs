using Client.View.Question;
using Client.View.Diagram;
using Client.View.Dialogs;
using System.Windows.Forms;
using Client.Factory;
using System;
using Client.Model;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net;
using RestSharp;

namespace Client.Controller
{
    public class PrefilledList
    {
        private String key { get; set; }
        private int value { get; set; }

        public PrefilledList(String key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public class QuestionController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(Question message);
        #endregion

        #region Declare Events
        public event SelectedIndexChanged selectedIndexChanged;
        #endregion

        #region Properties
        private QuestionFactory qFactory = new QuestionFactory();
        private PredefinedAnswerFactory paFactory = new PredefinedAnswerFactory();
        public BindingList<Question> Questions = new BindingList<Question>();
        private Dictionary<String, int> preFilledList = new Dictionary<string, int>();
        private IQuestionView questionView;
        private IAddQuestionView addQuestionView;
        private TableLayoutPanel tableThreeColls;
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
            if (this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged((Question)this.questionView.getListBoxQuestions().SelectedItem);
            }
        }
        #endregion

        #region Methodes
        public void enableBtnGetAddQuestionPanel()
        {
            questionView.getBtnAddQuestion().Enabled = true;
        }

        public TableLayoutPanel getAddQuestionPanel()
        {
            return addQuestionView.getPanel();
        }

        public void setTable(TableLayoutPanel tableThreeColls)
        {
            this.tableThreeColls = tableThreeColls;
        }
    
        public void clearAddQuestion()
        {
            addQuestionView.getQuestionField().ResetText();
            addQuestionView.getPointsField().ResetText();
            addQuestionView.getTimeField().ResetText();
            addQuestionView.getAnswersListBox().Items.Clear();
            addQuestionView.getRightAnswerComboBox().Items.Clear();
        }

        private void LoadAddQuestionHandler(object sender, System.EventArgs e)
        {
            addQuestionView = new ViewAddQuestion();
            addQuestionView.setController(this);

            addQuestionView.getBtnSaveQuestion().Click += saveQuestion;
            addQuestionView.getBtnQuit().Click += QuitAddQuestionHandler;
            addQuestionView.getBtnAddAnswer().Click += addAnswerToListBox;
            addQuestionView.getBtnDeleteAnswer().Click += removeAnswerFromListBox;

            tableThreeColls.SuspendLayout();
            if (tableThreeColls.ColumnStyles[2].Width <= 0)
            {
                float width = 0;
                for (int i = 0; i < tableThreeColls.ColumnCount; i++)
                {
                    if (i != 2)
                    {
                        width = 30F;
                    }
                    else
                    {
                        width = 40F;
                    }
                    tableThreeColls.ColumnStyles[i].Width = width;

                }
                tableThreeColls.Controls.Add(addQuestionView.getPanel(), 2, 0);
            }
            tableThreeColls.ResumeLayout(true);
            tableThreeColls.PerformLayout();
        }

        private void saveQuestion(object sender, EventArgs e)
        {
            if (addQuestionView.getQuestionField().Text != "" && (int)addQuestionView.getTimeField().Value != 0 && addQuestionView.getPointsField().Value != 0 && addQuestionView.getRightAnswerComboBox().SelectedItem != null)
            {
                //Show dialog for user to confirm Delete action
                DialogResult dr = new DialogResult();
                ViewConfirmDialog confirm = new ViewConfirmDialog();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u de vraag wilt opslaan?";
                dr = confirm.ShowDialog();

                if(dr == DialogResult.Yes)
                {
                    Question q = new Question();
                    q.Text = addQuestionView.getQuestionField().Text;
                    q.Time = (int)addQuestionView.getTimeField().Value;
                    q.Points = (int)addQuestionView.getPointsField().Value;
                    q.List_Id = this.listId;
                    q.PredefinedAnswerCount = addQuestionView.getAnswersListBox().Items.Count;

                    qFactory.Save(q, addQuestionView.getAnswersListBox(), CB_SaveQuestion);                    
                }
            }
            else
            {
                ViewFailedDialog failed = new ViewFailedDialog();
                failed.getLabelFailed().Text = "Gelieve alle velden in te vullen!";
                failed.ShowDialog();
            }
        }

        //Callback function SaveQuestion
        private void CB_SaveQuestion(Question question, HttpStatusCode status, IRestResponse res)
        {
            if (status == HttpStatusCode.Created)
            {
                //Save Question succeed
                //add Question to Bindinglist
                this.Questions.Add(question);
                saveAnswers(question);
            }
            else
            {
                //Save question failed
                ViewFailedDialog failed = new ViewFailedDialog();
                failed.getLabelFailed().Text = "Het opslaan is mislukt! Probeer het opnieuw.";
                failed.ShowDialog();
            }
        }

        private void saveAnswers(Question q)
        {           
            string rightAnswer = (string)addQuestionView.getRightAnswerComboBox().SelectedItem;
            int countPA = addQuestionView.getAnswersListBox().Items.Count;
            PredefinedAnswer pa;

            foreach (String answer in addQuestionView.getAnswersListBox().Items)
            {
                preFilledList.Add(answer, 0);
            }

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
                pa.Question = q;
                paFactory.Save(pa, addQuestionView.getAnswersListBox(), CB_SaveAnswers);
            }
        }

        private void CB_SaveAnswers(PredefinedAnswer pa, HttpStatusCode status, IRestResponse res)
        {
            if (status == HttpStatusCode.Created && pa != null)
            {
                preFilledList[pa.Text] = 1;
            }
            else
            {
                preFilledList[pa.Text] = 2;
            }

            if(!preFilledList.ContainsValue(0))
            {
                if(preFilledList.ContainsValue(2))
                {
                    qFactory.DeleteAsync(pa.Question);
                    
                    ViewFailedDialog failed = new ViewFailedDialog();
                    failed.getLabelFailed().Text = "Het opslaan is mislukt! Probeer het opnieuw.";
                    failed.ShowDialog();
                }
                else
                {
                    //Save Answers succeed
                    ViewSuccesDialog succes = new ViewSuccesDialog();
                    succes.getLabelSucces().Text = "De vraag is succesvol opgeslagen!";
                    succes.ShowDialog();
                }
            }
        }

        private void QuitAddQuestionHandler(object sender, System.EventArgs e)
        {
            tableThreeColls.SuspendLayout();
            tableThreeColls.Controls.RemoveAt(2);
            float width = 0;
            for (int i = 0; i < tableThreeColls.ColumnCount; i++)
            {
                if (i < 2)
                {
                    width = 50F;
                }
                else
                {
                    width = 0;
                }
                tableThreeColls.ColumnStyles[i].Width = width;
            }
            tableThreeColls.ResumeLayout(true);
            tableThreeColls.PerformLayout();
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

                        ViewFailedDialog failed = new ViewFailedDialog();
                        failed.getLabelFailed().Text = "Dit antwoord bestaat al.";
                        failed.ShowDialog();
                    }
                }

                if (!listExists)
                {
                    addQuestionView.getAnswersListBox().Items.Add(addQuestionView.getAnswerField().Text);
                    addQuestionView.getRightAnswerComboBox().Items.Add(addQuestionView.getAnswerField().Text);
                }
            }
            else
            {
                ViewFailedDialog failed = new ViewFailedDialog();
                failed.getLabelFailed().Text = "Voer een antwoord in.";
                failed.ShowDialog();
            }
        }

        private void removeAnswerFromListBox(object sender, EventArgs e)
        {
            if (addQuestionView.getAnswersListBox().Items.Count > 0)
            {
                if (addQuestionView.getAnswersListBox().SelectedIndex >= 0)
                {
                    String deleteItem = addQuestionView.getAnswersListBox().SelectedItem.ToString();
                    addQuestionView.getRightAnswerComboBox().Items.Remove(deleteItem);
                    addQuestionView.getAnswersListBox().Items.Remove(deleteItem);
                }
                else
                {
                    ViewFailedDialog failed = new ViewFailedDialog();
                    failed.getLabelFailed().Text = "Selecteer het antwoord dat u wilt verwijderen.";
                    failed.ShowDialog();
                }
            }
            else
            {
                ViewFailedDialog failed = new ViewFailedDialog();
                failed.getLabelFailed().Text = "Er bestaan nog geen antwoorden.";
                failed.ShowDialog();
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
                qFactory.Delete(q, this.questionView.getListBoxQuestions(), processDelete);
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
            qFactory.FindAll(questionView.getListBoxQuestions(), this.fillList);
        }

        #endregion
    }
}
