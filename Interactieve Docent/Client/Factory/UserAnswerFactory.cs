using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class UserAnswerFactory : AbstractFactory<UserAnswer>
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

        #region Properties
        protected override string resource
        {
            get
            {
                return "UserAnswers";
            }
        }
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
        protected override Dictionary<string, object> getFields(UserAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("PredefinedAnswer_Id", answer.PredefinedAnswer_Id);

            return values;
        }
        #endregion
    }
}
