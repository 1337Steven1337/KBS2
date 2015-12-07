using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;

namespace Client.Factory
{
    public class UserAnswerFactory : AbstractFactory<UserAnswer>
    {
        #region Delegates
        public delegate void UserAnswerAddedDelegate(UserAnswer answer);
        public delegate void UserAnswerRemovedDelegate(UserAnswer answer);
        public delegate void UserAnswerUpdatedDelegate(UserAnswer answer);
        #endregion

        #region Events
        public event UserAnswerAddedDelegate UserAnswerAdded;
        public event UserAnswerRemovedDelegate UserAnswerRemoved;
        public event UserAnswerUpdatedDelegate UserAnswerUpdated;
        #endregion

        #region Properties
        protected override string Resource
        {
            get
            {
                return "UserAnswers";
            }
        }
        #endregion

        #region Constructors
        public UserAnswerFactory() : base(new BaseFactory<UserAnswer>())
        {
            this.SignalRClient.proxy.On<UserAnswer>("UserAnswerAdded", this.OnUserAnswerAdded);
            this.SignalRClient.proxy.On<UserAnswer>("UserAnswerRemoved", this.OnUserAnswerRemoved);
            this.SignalRClient.proxy.On<UserAnswer>("UserAnswerUpdated", this.OnUserAnswerUpdated);
        }
        #endregion

        #region Actions
        private void OnUserAnswerAdded(UserAnswer a)
        {
            if (this.UserAnswerAdded != null)
            {
                this.UserAnswerAdded(a);
            }
        }
        private void OnUserAnswerRemoved(UserAnswer a)
        {
            if (this.UserAnswerRemoved != null)
            {
                this.UserAnswerRemoved(a);
            }
        }
        private void OnUserAnswerUpdated(UserAnswer a)
        {
            if (this.UserAnswerUpdated != null)
            {
                this.UserAnswerUpdated(a);
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> GetFields(UserAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("PredefinedAnswer_Id", answer.PredefinedAnswer_Id);

            return values;
        }
        #endregion
    }
}
