using Client.API.Models;
using System;
using System.Collections.Generic;

namespace Client.Factory
{
    class PredefinedAnswerFactory : AbstractFactory
    {
        private const string resource = "PredefinedAnswers";

        public void save(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);

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
