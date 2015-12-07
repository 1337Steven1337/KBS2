using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View;
using Client.View.QuestionList;

namespace Client.Tests.View.QuestionList
{
    public class TestViewQuestionList : IQuestionListView
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

        public IControlHandler getHandler()
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

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }
    }
}
