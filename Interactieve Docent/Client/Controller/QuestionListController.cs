using Client.Factory;
using Client.View.QuestionList;
using Client.Model;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Client.Controller
{
    public class QuestionListController
    {
        private IQuestionListView questionListView;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;


        public QuestionListController(IQuestionListView questionListView, QuestionController questionController)
        {
            //Defining the left panel it's appearance
            this.questionListView = questionListView;
            this.questionListView.setController(this);

            this.questionController = questionController;

            loadLists();
        }

        public void saveList(string name)
        {
            Model.QuestionList ql = new Model.QuestionList();
            ql.Name = name;
            factory.Save(ql, questionListView.getHandler(), processAdd);
        }


        public void deleteList(int id)
        {            
            Model.QuestionList ql = new Model.QuestionList();
            ql.Id = id;
            //Send ql to server for deleting
            //factory.Delete(ql, this.questionListView.getListBoxQuestionLists(), processDelete);
            factory.Delete(ql, questionListView.getHandler(), processDelete);
        }

        //Without sending request to server, 'refresh' list (add added item)
        private void processAdd(Model.QuestionList ql)
        {
            this.questionListView.Add(ql);
        }

        //Without sending request to server, 'refresh' list (remove removed item)
        private void processDelete(Model.QuestionList ql)
        {
            int i;
            for (i = 0;  i < this.questionListView.getCount(); i++)
            {
                if(this.questionListView.getItem(i).Id == ql.Id)
                {
                    break;
                }
            }

            this.questionListView.RemoveAt(i);
        }

        //Requests all lists via from database
        private void loadLists()
        {
            //factory.FindAll(this.questionListView.getListBoxQuestionLists(), this.fillList);
        }

        //Adding requested lists to listbox
        private void fillList(List<Model.QuestionList> lists)
        {
            foreach(Model.QuestionList q in lists)
            {
                this.questionListView.Add(q);
            }
            //Enable button to add a question, only when item in listbox is selected
            questionController.enableBtnGetAddQuestionPanel();
            questionController.loadQuestions(this.questionListView.getSelectedItem().Id);
        }

        //If selected list changes, load it's questions
        public void IndexChanged()
        {   
            questionController.loadQuestions(this.questionListView.getSelectedItem().Id);
        }
    }
}
