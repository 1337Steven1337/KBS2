using Client.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public void findAll(Control control, Action<List<Question>> callback)
        {
            this.findAll<Question>(resource, control, callback);
        }

        public void findAllAsync(Action<List<Question>> callback)
        {
            this.findAllAsync<Question>(resource, callback);
        }
    }
}
