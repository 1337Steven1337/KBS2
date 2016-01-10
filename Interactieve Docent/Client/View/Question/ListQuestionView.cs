using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.View.Main;
using System.ComponentModel;
using Client.Controller.Question;
using Client.Model;
using System.Net;
using Client.View.Dialogs;
using System.Linq;
using Client.View.Diagram;
using MetroFramework.Forms;
using System.Drawing;
using Client.Factory;

namespace Client.View.Question
{
    public partial class ListQuestionView : MetroForm, IListView<Model.Question>
    {
        #region Delegates
        public delegate void AddQuestionClickedDelegate(Model.QuestionList list, Model.Question question);
        #endregion

        #region Events
        public event AddQuestionClickedDelegate AddQuestionClicked;
        #endregion

        #region Properties
        public BindingList<Model.Question> Questions = new BindingList<Model.Question>();
        #endregion

        #region Instances
        private ListQuestionController Controller { get; set; }
        private DiagramController DiagramController { get; set; }
        #endregion

        #region Constructors
        public ListQuestionView()
        {
            InitializeComponent();

            listBoxQuestions.DisplayMember = "Text";
            listBoxQuestions.ValueMember = "Id";

            listBoxQuestions.DataSource = this.Questions;

            listBoxQuestions.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            listBoxQuestions.PreviewKeyDown += ListBoxQuestions_PreviewKeyDown;
            btnAddQuestion.Click += BtnAddQuestion_Click;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            btnShowResults.Click += btnShowResults_Click;
        }

        private void QuestionAddedWhileLoopingThroughList()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Event handlers
        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            if (this.AddQuestionClicked != null)
            {
                this.AddQuestionClicked(this.Controller.CurrentList, null);
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.DiagramController != null && !this.DiagramController.IsClosed)
            {
                this.DiagramController.SetQuestion((Model.Question)this.listBoxQuestions.SelectedItem);
            }
        }

        //Draw custom colors in Listbox
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < listBoxQuestions.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(243, 119, 53) : Color.FromArgb(17, 17, 17));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = listBoxQuestions.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.FromArgb(153, 153, 153));
                g.DrawString(itemText, e.Font, itemTextColorBrush, listBoxQuestions.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }
        #endregion

        #region Methods
        public void FillList(List<Model.Question> list)
        {
            loadingSpinner.Visible = false;
            titleTile.Text = String.Format("Vragen uit: {0}", this.Controller.CurrentList.Name);
            this.Questions.Clear();

            foreach (Model.Question question in list)
            {
                this.Questions.Add(question);
            }

            btnAddQuestion.Enabled = true;
            btnDeleteQuestion.Enabled = true;
            btnShowResults.Enabled = true;
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.listBoxQuestions);
        }

        public void AddToParent(IView parent)
        {
            MainView main = (MainView)parent;
            main.AddTablePanel(this.mainTablePanel, 2);
        }

        public void SetController(IController controller)
        {
            this.Controller = (ListQuestionController)controller;
        }

        private void ListBoxQuestions_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeleteQuestion_Click(sender, e);
            }
        }

        public Model.Question getSelectedItem()
        {
            return (Model.Question)this.listBoxQuestions.SelectedItem;
        }

        public void AddItem(Model.Question question)
        {
            Questions.Add(question);
        }

        public void DeleteItem(Model.Question item)
        {
            Questions.Remove(Questions.First(x => x.Id == item.Id));
        }


        public void ShowDeleteQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }
        #endregion       

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            //checks if selected item contains a question
            if(getSelectedItem() != null)
            {
                //Show dialog for user to confirm Delete action
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = String.Format("Weet u zeker dat u de vraag: {0}{1}wilt verwijderen?", getSelectedItem().Text, "\n");
                dr = confirm.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    this.Controller.DeleteQuestion(this.getSelectedItem());
                }
            }
        }

        public void ShowDeleteQuestionResult(Model.Question instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && instance != null)
            {
                //Delete question from questions
                DeleteItem(instance);

                //Show dialog action succeed
                SuccesDialogView succes = new SuccesDialogView();
                succes.getLabelSucces().Text = "De vraag is succesvol verwijderd.";
                succes.ShowDialog();
            }
            else
            {
                //Show dialog action failed
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Oeps! Er is iets misgegaan! Probeer het opnieuw.";
                failed.ShowDialog();
            }
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            if (this.DiagramController != null)
            {
                this.DiagramController.Close();
            }

            DiagramView view = new DiagramView();
            this.DiagramController = new DiagramController(view);
            view.Show();

            this.DiagramController.SetQuestion((Model.Question)this.listBoxQuestions.SelectedItem);
        }

        private void listBoxQuestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //If question have answers from students, the question cannot be updated.
            if (Controller.QuestionCanBeUpdated())
            {
                if (this.AddQuestionClicked != null)
                {
                    this.AddQuestionClicked(this.Controller.CurrentList, getSelectedItem());
                }
            }
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Deze vraag kan niet geupdate worden omdat de vraag nog antwoorden bevat van studenten.";
                failed.ShowDialog();
            }
        }

        public void ShowSaveQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowUpdateQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }
    }
}
