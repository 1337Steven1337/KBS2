using System.Windows.Forms;
using Client.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;
using Client.Service.Thread;
using Client.View.Main;
using Client.Controller.QuestionList;
using Client.Model;
using System.Net;
using Client.View.Dialogs;
using Client.View.Question;

namespace Client.View.QuestionList
{
    public partial class ListQuestionListView : Form, IListView<Model.QuestionList>
    {
        #region Properties
        public BindingList<Model.QuestionList> QuestionLists = new BindingList<Model.QuestionList>();
        #endregion

        #region Instances
        private ListQuestionListController Controller { get; set; }
        #endregion

        #region Constructors
        public ListQuestionListView()
        {
            InitializeComponent();

            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";
            listBoxQuestionLists.DataSource = this.QuestionLists;

            btnAddQuestionList.Click += BtnAddQuestionList_Click;
            btnDeleteQuestionList.Click += BtnDeleteQuestionList_Click;

            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBoxQuestionLists.PreviewKeyDown += ListBoxQuestionLists_PreviewKeyDown;
        }

        #endregion

        #region Event handlers
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controller.SelectedIndexChanged(this.getSelectedItem());
        }
        #endregion

        #region Methods
        public void AddToParent(IView parent)
        {
            MainView main = (MainView)parent;
            main.AddTablePanel(this.mainTablePanel, 1);
        }

        public void FillList(List<Model.QuestionList> list)
        {
            this.QuestionLists.Clear();

            foreach (Model.QuestionList questionList in list)
            {
                this.QuestionLists.Add(questionList);
            }

            this.Controller.SelectedIndexChanged(this.getSelectedItem());
        }

        public void SetController(IController controller)
        {
            this.Controller = (ListQuestionListController)controller;
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.listBoxQuestionLists);
        }

        public Model.QuestionList getSelectedItem()
        {
            return (Model.QuestionList)this.listBoxQuestionLists.SelectedItem;
        }

        private void ListBoxQuestionLists_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BtnDeleteQuestionList_Click(sender, e);
            }
        }

        private void BtnAddQuestionList_Click(object sender, EventArgs e)
        {
            //Open dialog where user enters name for new list
            AddQuestionListView dlg = new AddQuestionListView();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();

            //Check if name is entered correctly and user pressed Ok-button
            if (dlg.valid)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data["Name"] = dlg.text;
                Controller.SaveQuestionList(data);
            }
        }

        public void ShowSaveQuestionListResult(Model.QuestionList list, HttpStatusCode status)
        {
            //Check if added to database
            if (status == HttpStatusCode.Created && list != null)
            {
                //Visually adding the new list to the listbox
                AddItem(list);
            }
            else
            {
                //Give user feedback of failure
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Oeps! Er is iets misgegaan! Probeer het opnieuw!";
                failed.ShowDialog();
            }
        }

        private void BtnDeleteQuestionList_Click(object sender, EventArgs e)
        {
            //Show dialog for user to confirm Delete action
            DialogResult dr = new DialogResult();
            ConfirmDialogView confirm = new ConfirmDialogView();
            confirm.getLabelConfirm().Text = "Weet u zeker dat u deze lijst wilt verwijderen?";
            dr = confirm.ShowDialog();

            if(dr == DialogResult.Yes)
            {
                this.Controller.DeleteQuestionList(this.getSelectedItem());
            }
        }

        public void ShowDeleteQuestionListResult(Model.QuestionList list, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && list != null)
            {
                DeleteItem(list);

                SuccesDialogView succes = new SuccesDialogView();
                succes.getLabelSucces().Text = "De lijst is succesvol verwijderd!!";
                succes.ShowDialog();
            }
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "Oeps! Er is iets misgegaan! Probeer het opnieuw!";
                failed.ShowDialog();
            }
        }

        public void AddItem(Model.QuestionList list)
        {
            QuestionLists.Add(list);
        }

        public void DeleteItem(Model.QuestionList list)
        {
            QuestionLists.Remove(QuestionLists.First(x => x.Id == list.Id));
        }
        #endregion        
    }
}
