using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class UserAnswerFactory : AbstractFactory
    {
        #region Delegates
        public delegate void UserAnswerAdded(UserAnswer answer);
        public delegate void UserAnswerRemoved(UserAnswer answer);
        public delegate void UserAnswerUpdated(UserAnswer answer);
        #endregion

        #region Events
        public event UserAnswerAdded userAnswerAdded;
        public event UserAnswerRemoved userAnswerRemoved;
        public event UserAnswerUpdated userAnswerUpdated;
        #endregion

        #region Constants
        private const string resource = "PredefinedAnswers";
        #endregion

        #region Constructors
        public UserAnswerFactory()
        {
            this.signalRClient.proxy.On<UserAnswer>("UserAnswerAdded", this.onUserAnswerAdded);
            this.signalRClient.proxy.On<UserAnswer>("UserAnswerRemoved", this.onUserAnswerRemoved);
            this.signalRClient.proxy.On<UserAnswer>("UserAnswerUpdated", this.onUserAnswerUpdated);
        }
        #endregion

        #region Actions
        private void onUserAnswerAdded(UserAnswer a)
        {
            if (this.userAnswerAdded != null)
            {
                this.userAnswerAdded(a);
            }
        }

        private void onUserAnswerRemoved(UserAnswer a)
        {
            if (this.userAnswerRemoved != null)
            {
                this.userAnswerRemoved(a);
            }
        }

        private void onUserAnswerUpdated(UserAnswer a)
        {
            if (this.userAnswerUpdated != null)
            {
                this.userAnswerUpdated(a);
            }
        }
        #endregion

        #region Methods
        public void saveAsync(UserAnswer answer, Action<UserAnswer> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("PredefinedAnswer_Id", answer.PredefinedAnswer_Id);

            this.saveAsync<UserAnswer>(values, resource, callback);
        }

        public void save(UserAnswer answer, Control control, Action<UserAnswer> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("PredefinedAnswer_Id", answer.PredefinedAnswer_Id);

            this.save<UserAnswer>(values, resource, control, callback);
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
        #endregion
    }
}
