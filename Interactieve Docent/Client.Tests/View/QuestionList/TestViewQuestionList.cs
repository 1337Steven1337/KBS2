using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;
using Client.Controller;
using Client.Controller.QuestionList;
using Client.Model;
using Client.Service.Thread;
using Client.View;
using Client.View.QuestionList;
using System.Net;
using Client.Controller.Question;

namespace Client.Tests.View.QuestionList
{
    public class TestViewQuestionList : IListView<Model.QuestionList>
    {
        private ListQuestionListController controller;
        public List<Model.QuestionList> questionlists = new List<Model.QuestionList>();

        public TestViewQuestionList()
        {

        }


        public void Add(Model.QuestionList ql)
        {
            questionlists.Add(ql);
        }

        public int getCount()
        {
            return questionlists.Count;
        }

        public IControlHandler GetHandler()
        {
            return new TestControlHandler();
        }

        public Model.QuestionList getItem(int i)
        {
            return questionlists[i];
        }

        public List<Model.QuestionList> getQuestionlists()
        {
            return questionlists;
        }

        public Model.QuestionList getSelectedItem()
        {
            return questionlists.FirstOrDefault();
        }

        public void RemoveAt(int i)
        {
            questionlists.RemoveAt(i);
        }

        public void setController(ListQuestionListController controller)
        {
            this.controller = controller;
        }

        public Model.QuestionList getById(int i)
        {
            foreach (Model.QuestionList q in questionlists)
            {
                if (q.Id == i)
                {
                    return q;
                }
            }
            return null;
        }

        public void AddToList(Model.Question q, int list_Id)
        {
            foreach (Model.QuestionList ql in questionlists)
            {
                if(ql.Id == list_Id)
                {
                    ql.MCQuestions.Add(q);
                }
            }
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.QuestionList> list)
        {
            foreach(Model.QuestionList questionList in list)
            {
                this.questionlists.Add(questionList);
            }
        }

        public void SetController(IController controller)
        {

        }

        public void AddItem(Model.QuestionList item)
        {
            this.questionlists.Add(item);
        }

        public void ShowDeleteResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Model.QuestionList item)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
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

        public void ShowUpdateQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }
    }
}
