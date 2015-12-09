using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Client;
using Client.Model;

namespace Client.Tests.Factory
{
    class TestQuestionFactory : Client.Factory.IFactory<Question>
    {
        private List<Question> questions;

        public TestQuestionFactory()
        {
            questions = new List<Question>();
            Question q1 = new Question();
            Question q2 = new Question();
            Question q3 = new Question();
            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);
        }

        public void DeleteAsync(Question instance, Action<Question, HttpStatusCode, global::RestSharp.IRestResponse> callback)
        {
            questions.Remove(instance);

            callback(instance, HttpStatusCode.OK, null);
        }

        public void FindAllAsync(Action<List<Question>, HttpStatusCode, global::RestSharp.IRestResponse> callback)
        {
            callback(questions, HttpStatusCode.OK, null);
        }

        public void FindByIdAsync(int id, Action<Question, HttpStatusCode, global::RestSharp.IRestResponse> callback)
        {
            callback(questions[id], HttpStatusCode.OK, null);
        }

        public void SaveAsync(List<KeyValuePair<string, object>> data, Action<Question, HttpStatusCode, global::RestSharp.IRestResponse> callback)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            foreach(KeyValuePair<string, object> pair in data)
            {
                dictionary.Add(pair.Key, pair.Value);
            }

            Model.Question question = new Model.Question(dictionary);
            question.Id = new Random().Next(1, 99);

            callback(question, HttpStatusCode.Created, null);
        }

        public void SetResource(string resource)
        {
            //Q
        }
    }
}
