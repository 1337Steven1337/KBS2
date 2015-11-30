using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class QuestionFactory : AbstractFactory
    {
        #region Delegates
        public delegate void QuestionAdded(Question question);
        public delegate void QuestionRemoved(Question question);
        public delegate void QuestionUpdated(Question question);
        #endregion

        #region Events
        public event QuestionAdded questionAdded;
        public event QuestionRemoved questionRemoved;
        public event QuestionUpdated questionUpdated;
        #endregion

        #region Constants
        private const string resource = "Questions";
        #endregion

        #region Constructors
        public QuestionFactory()
        {
            this.signalRClient.proxy.On<Question>("QuestionAdded", this.onQuestionAdded);
            this.signalRClient.proxy.On<Question>("QuestionRemoved", this.onQuestionRemoved);
            this.signalRClient.proxy.On<Question>("QuestionUpdated", this.onQuestionUpdated);
        }
        #endregion

        #region Actions
        private void onQuestionAdded(Question q)
        {
            if (this.questionAdded != null)
            {
                this.questionAdded(q);
            }
        }

        private void onQuestionRemoved(Question q)
        {
            if (this.questionRemoved != null)
            {
                this.questionRemoved(q);
            }
        }

        private void onQuestionUpdated(Question q)
        {
            if (this.questionUpdated != null)
            {
                this.questionUpdated(q);
            }
        }
        #endregion

        #region Methods
        public void saveAsync(Question question, Action<Question> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Time", question.Time);
            values.Add("Points", question.Points);
            values.Add("List_Id", question.List_Id);

            this.saveAsync<Question>(values, resource, callback);
        }

        public void save(Question question, Control control, Action<Question> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Time", question.Time);
            values.Add("Points", question.Points);
            values.Add("List_Id", question.List_Id);

            this.save<Question>(values, resource, control, callback);
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
        #endregion
    }
}
