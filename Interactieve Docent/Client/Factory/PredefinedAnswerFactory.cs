using Client.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class PredefinedAnswerFactory : AbstractFactory
    {
        private const string resource = "PredefinedAnswers";

        public void delete(PredefinedAnswer answer, Control control, Action<PredefinedAnswer> callback)
        {
            this.delete<PredefinedAnswer>(answer.Id, resource, control, callback);
        }

        public void deleteAsync(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            this.deleteAsync<PredefinedAnswer>(answer.Id, resource, callback);
        }

        private Dictionary<string, object> getFields(PredefinedAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);
            values.Add("Question_Id", answer.Question_Id);

            return values;
        }

        public void saveAsync(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            this.saveAsync<PredefinedAnswer>(this.getFields(answer), resource, callback);
        }

        public void save(PredefinedAnswer answer, Control control, Action<PredefinedAnswer> callback)
        {
            this.save<PredefinedAnswer>(this.getFields(answer), resource, control, callback);
        }

        public void findByIdAsync(int id, Action<PredefinedAnswer> callback)
        {
            this.findByIdAsync<PredefinedAnswer>(id, resource, callback);
        }

        public void findById(int id, Control control, Action<PredefinedAnswer> callback)
        {
            this.findById<PredefinedAnswer>(id, resource, control, callback);
        }

        public void findAll(Control control, Action<List<PredefinedAnswer>> callback)
        {
            this.findAll<PredefinedAnswer>(resource, control, callback);
        }

        public void findAllAsync(Action<List<PredefinedAnswer>> callback)
        {
            this.findAllAsync<PredefinedAnswer>(resource, callback);
        }
    }
}
