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

            btnAddQuestionList.Click += new System.EventHandler(AddList);
            btnDeleteQuestionList.Click += new System.EventHandler(deleteList);

            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBoxQuestionLists.PreviewKeyDown += new PreviewKeyDownEventHandler(Delete_keyDown);
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
            main.AddTablePanel(this.mainTablePanel, 0);
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

        private void Delete_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteList(sender, e);
            }
        }

        private void AddList(object sender, EventArgs e)
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

        public void ProcessAdd(Model.QuestionList ql, HttpStatusCode status)
        {
            //Check if added to database
            if (status == HttpStatusCode.Created)
            {
                //Visually adding the new list to the listbox
                QuestionLists.Add(ql);
            }
            else
            {
                //Give user feedback of failure
                Dialogs.FailedDialogView dlg = new Dialogs.FailedDialogView();
                dlg.getLabelFailed().Text = "Oeps! Er is iets misgegaan! Probeer het opnieuw!";
                dlg.ShowDialog();
            }


        }

        private void deleteList(object sender, EventArgs e)
        {
            //Show dialog for user to confirm Delete action
            DeleteQuestionListView dlg = new DeleteQuestionListView();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(listBoxQuestionLists.SelectedItem.ToString());
            dlg.ShowDialog();

            //If user clicked Ok-button
            if (dlg.valid)
            {
                //Create instance ql of QuestionList with entered id as property
                //this.controller.deleteList((int)listBoxQuestionLists.SelectedValue);
            }
        }

        private void newList(object sender, EventArgs e)
        {
            //Dialog with field to enter name for new list 
            AddQuestionListView dlg = new AddQuestionListView();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();

            //If Ok-button clicked and entered text is valid, valid is true 
            if (dlg.valid)
            {
                //Create instance ql of QuestionList with entered name as property
                string name = dlg.text;
                //this.controller.saveList(name);
            }
        }

        public void AddItem(Model.QuestionList item)
        {
            throw new NotImplementedException();
        }
        #endregion        
    }
}
