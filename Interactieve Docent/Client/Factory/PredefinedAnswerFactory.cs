using Client.Model;
using System;
using System.Collections.Generic;

namespace Client.Factory
{
    public class PredefinedAnswerFactory : AbstractFactory
    {
        private const string resource = "PredefinedAnswers";

        public void save(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);
            values.Add("Question_Id", answer.Question_Id);

            this.save<PredefinedAnswer>(values, resource, callback);
        }

        public void findById(int id, Action<PredefinedAnswer> callback)
        {
            this.findById<PredefinedAnswer>(id, resource, callback);
        }

        public void findAll(Action<List<PredefinedAnswer>> callback)
        {
            this.findAll<PredefinedAnswer>(resource, callback);
        }
    }
}
