using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;

namespace Client.Tests.Factory
{
    public class TestQuestionListFactory : Client.Factory.IFactory<QuestionList>
    {
        private List<QuestionList> questionlists;

        public TestQuestionListFactory()
        {
            questionlists = new List<QuestionList>();
            QuestionList ql1 = new QuestionList();
            ql1.Id = 1;
            ql1.Name = "1";
            QuestionList ql2 = new QuestionList();
            ql2.Id = 2;
            ql2.Name = "2";
            QuestionList ql3 = new QuestionList();
            ql3.Id = 3;
            ql3.Name = "3";
            questionlists.Add(ql1);
            questionlists.Add(ql2);
            questionlists.Add(ql3);
        }

        public void DeleteAsync(QuestionList instance, Action<QuestionList, HttpStatusCode, IRestResponse> callback)
        {
            questionlists.Remove(instance);

            callback(instance, HttpStatusCode.OK, null);
        }

        public void ExecuteAsync<C>(IRestRequest request, Action<IRestResponse<C>> callback) where C : new()
        {
            throw new NotImplementedException();
        }

        public void FindAllAsync(Action<List<QuestionList>, HttpStatusCode, IRestResponse> callback)
        {
            callback(questionlists, HttpStatusCode.OK, null);
        }

        public void FindByIdAsync(int id, Action<QuestionList, HttpStatusCode, IRestResponse> callback)
        {
            callback(questionlists[id], HttpStatusCode.OK, null);
        }

        public void SaveAsync(List<KeyValuePair<string, object>> data, Action<QuestionList, HttpStatusCode, IRestResponse> callback)
        {
            QuestionList ql = new QuestionList();
            questionlists.Add(ql);

            callback(ql, HttpStatusCode.OK, null);
        }

        public void SetResource(string resource)
        {
            //Q
        }
    }
}
