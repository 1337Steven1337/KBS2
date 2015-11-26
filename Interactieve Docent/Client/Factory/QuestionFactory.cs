using Client.API.Models;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Client.Factory
{
    public class QuestionFactory : AbstractFactory
    {
        private const string resource = "Questions";

        public void save(Question question, Action<Question> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Time", question.Time);
            values.Add("Points", question.Points);
            values.Add("List_Id", question.List_Id);

            this.save<Question>(values, resource, callback);
        }

        public void findById(int id, Action<Question> callback)
        {
            this.findById<Question>(id, resource, callback);
        }

        public void findAll(Action<List<Question>> callback)
        {
            this.findAll<Question>(resource, callback);
        }
    }
}
