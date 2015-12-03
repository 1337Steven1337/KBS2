using Client.Factory;
using Client.View.QuestionList;
using System.Windows.Forms;
using Client.Model;
using Client.View.PanelLayout;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Client.Controller
{
    public class QuestionListController
    {
        private IQuestionListView questionListView;
        private ListBox listBoxQuestionLists;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;
        public BindingList<QuestionList> QuestionLists = new BindingList<QuestionList>();

        public QuestionListController(IQuestionListView questionListView, QuestionController questionController)
        {
            //Defining the left panel it's appearance
            this.listBoxQuestionLists = questionListView.getListBox();
            this.questionListView = questionListView;
            this.questionListView.setController(this);

            this.questionController = questionController;

            questionListView.getCustomPanel().middleRow.Controls.Add(listBoxQuestionLists);
            questionListView.getCustomPanel().title.Text = "VragenLijsten";

            //Eventhandlers for buttons/listboxes
            questionListView.getCustomPanel().leftBottomButton.Text = "Nieuwe lijst";
            questionListView.getCustomPanel().leftBottomButton.Click += new System.EventHandler(newList);
            questionListView.getCustomPanel().rightBottomButton.Text = "Verwijder lijst";
            questionListView.getCustomPanel().rightBottomButton.Click += new System.EventHandler(deleteList);

            loadLists();
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBoxQuestionLists.PreviewKeyDown += new PreviewKeyDownEventHandler(Delete_keyDown);
        }

        public TableLayoutPanel loadQuestionListView()
        {
            return questionListView.getCustomPanel().load();
        }

        public void newList(object sender, EventArgs e)
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
                QuestionList ql = new QuestionList();
                ql.Name = name;
                //Send instance ql to server for adding
                factory.save(ql, this.questionListView.getListBox(), processAdd);
            }
        }


        public void deleteList(object sender, EventArgs e)
        {
            //Show dialog for user to confirm delete action
            ViewDeleteQuestionList dlg = new ViewDeleteQuestionList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(listBoxQuestionLists.SelectedItem.ToString());
            dlg.ShowDialog();

            //If user clicked Ok-button
            if (dlg.valid)
            {
                //Create instance ql of QuestionList with entered id as property
                int id = (int)listBoxQuestionLists.SelectedValue;
                QuestionList ql = new QuestionList();
                ql.Id = id;
                //Send ql to server for deleting
                factory.delete(ql, this.questionListView.getListBox(), processDelete);
            }
        }

        //Without sending request to server, 'refresh' list (add added item)
        private void processAdd(QuestionList ql)
        {
            this.QuestionLists.Add(ql);
        }

        //Without sending request to server, 'refresh' list (remove removed item)
        private void processDelete(QuestionList ql)
        {
            int i;
            for (i = 0;  i < this.QuestionLists.Count; i++)
            {
                if(this.QuestionLists[i].Id == ql.Id)
                {
                    break;
                }
            }

            this.QuestionLists.RemoveAt(i);
        }

        //Requests all lists via from database
        private void loadLists()
        {
            factory.findAll(listBoxQuestionLists, this.fillList);
        }

        //Adding requested lists to listbox
        private void fillList(List<QuestionList> lists)
        {
            foreach(QuestionList q in lists)
            {
                this.QuestionLists.Add(q);
            }
        }

        //Delete list by selecting and pressing the delete-key
        private void Delete_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteList(sender, e);
            }
        }

        //If selected list changes, load it's questions
        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            questionController.loadQuestions((int)listBoxQuestionLists.SelectedValue);
        }
    }
}
