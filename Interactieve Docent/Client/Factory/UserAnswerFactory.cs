using Client.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class UserAnswerFactory : AbstractFactory
    {
        private const string resource = "PredefinedAnswers";

        public void save(UserAnswer answer, Action<UserAnswer> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("PredefinedAnswer_Id", answer.PredefinedAnswer_Id);

            this.save<UserAnswer>(values, resource, callback);
        }

        public void findById(int id, Action<UserAnswer> callback)
        {
            this.findById<UserAnswer>(id, resource, callback);
        }

        public void findAll(Control control, Action<List<UserAnswer>> callback)
        {
            this.findAll<UserAnswer>(resource, control, callback);
        }

        public void findAllAsync(Action<List<UserAnswer>> callback)
        {
            this.findAllAsync<UserAnswer>(resource, callback);
        }
    }
}
