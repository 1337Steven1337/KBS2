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
using Client.Service.Thread;
using Client.View;

namespace Client.Controller
{
    public class QuestionController : IController
    {
        #region Delegates
        public delegate void SelectedIndexChanged(Model.Question message);
        #endregion

        #region Declare Events
        public event SelectedIndexChanged selectedIndexChanged;
        #endregion

        #region Properties
        private QuestionFactory qFactory = new QuestionFactory();
        private PredefinedAnswerFactory paFactory = new PredefinedAnswerFactory();
        public BindingList<Model.Question> Questions = new BindingList<Model.Question>();
        private Dictionary<String, int> preFilledList = new Dictionary<string, int>();
        public IQuestionView<Model.Question> questionView { get; private set; }
        private IAddQuestionView<Model.Question> addQuestionView;
        private MainController mainController;
        private TableLayoutPanel tableThreeColls;
        private int listId { get; set; }

        #endregion

        #region Constructor
        public QuestionController(IQuestionView<Model.Question> questionView)
        {
            this.questionView = questionView;
            this.questionView.setController(this);
        }
        #endregion

        #region Events
        #endregion

        #region Methodes
        public void setMainController(MainController main)
        {
            this.mainController = main;
        }

        public void ListBoxQuestion_SelectedIndexChanged(object question)
        {
            if (this.selectedIndexChanged != null)
            {
                this.selectedIndexChanged((Model.Question)question);
            }
        }

        public void enableBtnGetAddQuestionPanel()
        {
            //questionView.getBtnAddQuestion().Enabled = true;
        }

        public TableLayoutPanel getAddQuestionPanel()
        {
            return addQuestionView.getPanel();
        }

        public void clearAddQuestion()
        {
            addQuestionView.getQuestionField().ResetText();
            addQuestionView.getPointsField().ResetText();
            addQuestionView.getTimeField().ResetText();
            addQuestionView.getAnswersListBox().Items.Clear();
            addQuestionView.getRightAnswerComboBox().Items.Clear();
        }

        public void loadAddQuestion()
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
                    Model.Question q = new Model.Question();
                    q.Text = addQuestionView.getQuestionField().Text;
                    q.Time = (int)addQuestionView.getTimeField().Value;
                    q.Points = (int)addQuestionView.getPointsField().Value;
                    q.List_Id = this.listId;
                    q.PredefinedAnswerCount = addQuestionView.getAnswersListBox().Items.Count;

                    qFactory.Save(q, new ControlHandler(addQuestionView.getAnswersListBox()), CB_SaveQuestion);                    
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
        private void CB_SaveQuestion(Model.Question question, HttpStatusCode status, IRestResponse res)
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

        private void saveAnswers(Model.Question q)
        {           
            string rightAnswer = (string)addQuestionView.getRightAnswerComboBox().SelectedItem;
            int countPA = addQuestionView.getAnswersListBox().Items.Count;
            PredefinedAnswer pa;
            preFilledList.Clear();

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
                paFactory.Save(pa, addQuestionView.GetHandler(), CB_SaveAnswers);
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

        public void deleteQuestion()
        {
            ViewDeleteQuestion dlg = new ViewDeleteQuestion();
            dlg.StartPosition = FormStartPosition.CenterParent;
            //dlg.setText(questionView.getListBoxQuestions().SelectedItem.ToString());
            dlg.ShowDialog();

            if (dlg.valid)
            {
                //int id = (int)questionView.getListBoxQuestions().SelectedValue;
                //Question q = new Question();
                //q.Id = id;
                //qFactory.Delete(q, this.questionView.getListBoxQuestions(), processDelete);
            }
        }

        public void showResults()
        {
            ViewDiagram view = new ViewDiagram();
            DiagramController controller = new DiagramController(view, this);
        }

        public void fillList(List<Model.Question> list)
        {
            this.Questions.Clear();
            List<Model.Question> filtered = list.FindAll(x => x.List_Id == this.listId);

            foreach (Model.Question q in filtered)
            {
                this.Questions.Add(q);
            }
        }

        public void processDelete(Model.Question q)
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
            //qFactory.FindAll(questionView.getListBoxQuestions(), this.fillList);
        }

        public IView GetView()
        {
            return this.questionView;
        }

        public void SetView(IView view)
        {
            throw new NotImplementedException();
        }

        public void SetBaseFactory(IFactory<Model.QuestionList> factory)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
