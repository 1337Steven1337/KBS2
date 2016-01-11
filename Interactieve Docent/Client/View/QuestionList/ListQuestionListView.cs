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
using Client.View.Docent;
using Client.Service.SignalR;
using Client.Controller.Question;

namespace Client.View.QuestionList
{
    public partial class ListQuestionListView : Form, IListView<Model.QuestionList>
    {
        #region Properties
        public BindingList<Model.QuestionList> QuestionLists = new BindingList<Model.QuestionList>();
        #endregion

        #region Instances
        private ListQuestionListController Controller { get; set; }
        private MainView main { get; set; }
        private RenameQuestionList RenameQuestionListDialog { get; set; }
        #endregion

        #region Constructors
        public ListQuestionListView()
        {
            InitializeComponent();
            this.Enabled = false;
            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";
            listBoxQuestionLists.DataSource = this.QuestionLists;

            btnAddQuestionList.Click += BtnAddQuestionList_Click;
            btnDeleteQuestionList.Click += BtnDeleteQuestionList_Click;
            btnStartQuestionList.Click += BtnStartQuestionList_Click;

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
            main = (MainView)parent;
            main.AddTablePanel(this.mainTablePanel, 1);
        }

        public void FillList(List<Model.QuestionList> list)
        {
            this.QuestionLists.Clear();

            foreach (Model.QuestionList questionList in list)
            {
                this.QuestionLists.Add(questionList);
            }
            this.btnAddQuestionList.Enabled = true;
            this.btnDeleteQuestionList.Enabled = true;
            this.btnStartQuestionList.Enabled = true;
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
            if (getSelectedItem() != null)
            {
                //Show dialog for user to confirm Delete action
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = String.Format("Weet u zeker dat u {0} wilt verwijderen?", getSelectedItem().Name);
                dr = confirm.ShowDialog();

                //Confirm 
                if (dr == DialogResult.Yes)
                {
                    this.Controller.DeleteQuestionList(this.getSelectedItem());
                }
            }
        }

        private void BtnStartQuestionList_Click(object sender, EventArgs e)
        {
            if (getSelectedItem() != null)
            {
                //Show dialog for user to confirm Start action
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u deze lijst wilt starten?";
                dr = confirm.ShowDialog();

                //Confirm 
                if (dr == DialogResult.Yes)
                {
                    SignalRClient.GetInstance().StartQuestionList(this.getSelectedItem().Id, Properties.Settings.Default.Session_Id);

                    //open docentomgeving
                    DocentOmgevingView view = new DocentOmgevingView();
                    DocentOmgevingController Controller = new DocentOmgevingController(view, getSelectedItem());

                }
            }
        }
        
        public void ShowDeleteQuestionListResult(Model.QuestionList list, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && list != null)
            { 
                //Delete list from QuestionLists
                DeleteItem(list);

                //Show dialog action succeed
                SuccesDialogView succes = new SuccesDialogView();
                succes.getLabelSucces().Text = "De lijst is succesvol verwijderd.";
                succes.ShowDialog();
            }
            else
            {
                //Show dialog action failed
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

        public void ShowDeleteQuestionResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Model.QuestionList item)
        {
            throw new NotImplementedException();
        }

        Model.Question IListView<Model.QuestionList>.getSelectedItem()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void listBoxQuestionLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // if you double click on in the listbox check if there is a questionlist underneed your cursor
            int index = this.listBoxQuestionLists.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //if there is open a dialog
                RenameQuestionListDialog = new RenameQuestionList(this.getSelectedItem().Id, this.Controller);
                // make the background go darker
                BackgroundDialogView view = new BackgroundDialogView(main, RenameQuestionListDialog);
                if (RenameQuestionListDialog.QuestionListNameChanged)
                {
                    //if the name is really changed reload the listbox to see the change
                    this.Controller.Load();
                }
            }
        }

        public void ShowUpdateQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            //check the result
            if (status == HttpStatusCode.OK)
            {
                //if you get back an OK result then close the dialog 
                RenameQuestionListDialog.Close();
            }
        }
    }
}
