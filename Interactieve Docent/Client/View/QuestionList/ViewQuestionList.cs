using System.Windows.Forms;
using Client.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using Client.Model;
using System;
using System.Linq;
using Client.Service.Thread;

namespace Client.View.QuestionList
{
    public partial class  ViewQuestionList : Form, IQuestionListView
    {
        public BindingList<Model.QuestionList> QuestionLists = new BindingList<Model.QuestionList>();
        private QuestionListController controller;
        public ViewQuestionList()
        {
            InitializeComponent();
            //Set which data from the items are to access in the listbox
            listBoxQuestionLists.DisplayMember = "Name";
            listBoxQuestionLists.ValueMember = "Id";

            btnAddQuestionList.Click += new System.EventHandler(newList);
            btnDeleteQuestionList.Click += new System.EventHandler(deleteList);
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBoxQuestionLists.PreviewKeyDown += new PreviewKeyDownEventHandler(Delete_keyDown);
        }

        private void Delete_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteList(sender, e);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controller.IndexChanged();
        }

        private void deleteList(object sender, EventArgs e)
        {
            //Show dialog for user to confirm Delete action
            ViewDeleteQuestionList dlg = new ViewDeleteQuestionList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(listBoxQuestionLists.SelectedItem.ToString());
            dlg.ShowDialog();

            //If user clicked Ok-button
            if (dlg.valid)
            {
                //Create instance ql of QuestionList with entered id as property
                this.controller.deleteList((int)listBoxQuestionLists.SelectedValue);
            }
        }

        private void newList(object sender, EventArgs e)
        {
            //Dialog with field to enter name for new list 
            ViewNewQuestionList dlg = new ViewNewQuestionList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();

            //If Ok-button clicked and entered text is valid, valid is true 
            if (dlg.valid)
            {
                //Create instance ql of QuestionList with entered name as property
                string name = dlg.text;
                this.controller.saveList(name);
            }
        }

        public void setController(QuestionListController controller)
        {
            //Attach to controller
            this.controller = controller;
            listBoxQuestionLists.DataSource = this.QuestionLists;
        }

           

        public Button getBtnAddQuestionList()
        {
            return btnAddQuestionList;
        }
        
        public Button getBtnDeleteQuestionList()
        {
            return btnDeleteQuestionList;
        }

        public TableLayoutPanel getPanel()
        {
            return mainTablePanel;
        }

        public List<Model.QuestionList> getQuestionlists()
        {
            return this.QuestionLists.ToList();
        }

        public Model.QuestionList getSelectedItem()
        {
            return (Model.QuestionList)this.listBoxQuestionLists.SelectedItem;
        }

        public void Add(Model.QuestionList ql)
        {
            this.QuestionLists.Add(ql);
        }

        public int getCount()
        {
            return this.QuestionLists.Count;
        }

        public Model.QuestionList getItem(int i)
        {
            return QuestionLists[i];
        }

        public void RemoveAt(int i)
        {
            this.QuestionLists.RemoveAt(i);
        }

        public IControlHandler getHandler()
        {
            return new ControlHandler(this.listBoxQuestionLists);
        }

        public Model.QuestionList getById(int i)
        {
            foreach(Model.QuestionList q in QuestionLists)
            {
                if(q.Id == i)
                {
                    return q;
                }
            }
            return null;
        }
    }
}