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

namespace Client.Tests.View.QuestionList
{
    public class TestViewQuestionList : IQuestionListView<Model.QuestionList>
    {
        private QuestionListController controller;
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

        public void setController(QuestionListController controller)
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
                    ql.Questions.Add(q);
                }
            }
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.QuestionList> list)
        {
            throw new NotImplementedException();
        }

        public void setController(ListQuestionListController controller)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        public void ProcessAdd(Model.QuestionList ql, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }
    }
}
