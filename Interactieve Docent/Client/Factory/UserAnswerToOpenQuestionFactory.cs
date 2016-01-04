using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Factory
{
    class UserAnswerToOpenQuestionFactory : AbstractFactory<UserAnswerToOpenQuestion>
    {
        #region Delegates
        public delegate void UserAnswerToOpenQuestionAddedDelegate(UserAnswerToOpenQuestion answer);
        public delegate void UserAnswerToOpenQuestionRemovedDelegate(UserAnswerToOpenQuestion answer);
        public delegate void UserAnswerToOpenQuestionUpdatedDelegate(UserAnswerToOpenQuestion answer);
        #endregion

        #region Events
        public event UserAnswerToOpenQuestionAddedDelegate UserAnswerToOpenQuestionAdded;
        public event UserAnswerToOpenQuestionRemovedDelegate UserAnswerToOpenQuestionRemoved;
        public event UserAnswerToOpenQuestionUpdatedDelegate UserAnswerToOpenQuestionUpdated;
        #endregion

        #region Properties
        protected override string Resource
        {
            get
            {
                return "UserAnswerToOpenQuestions";
            }
        }
        #endregion

        #region Constructors
        public UserAnswerToOpenQuestionFactory() : base(new BaseFactory<UserAnswerToOpenQuestion>())
        {
            this.SignalRClient.proxy.On<UserAnswerToOpenQuestion>("UserAnswerToOpenQuestionAdded", this.OnUserAnswerToOpenQuestionAdded);
            this.SignalRClient.proxy.On<UserAnswerToOpenQuestion>("UserAnswerToOpenQuestionRemoved", this.OnUserAnswerToOpenQuestionRemoved);
            this.SignalRClient.proxy.On<UserAnswerToOpenQuestion>("UserAnswerToOpenQuestionUpdated", this.OnUserAnswerToOpenQuestionUpdated);
        }
        #endregion

        #region Actions
        private void OnUserAnswerToOpenQuestionAdded(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionAdded != null)
            {
                this.UserAnswerToOpenQuestionAdded(a);
            }
        }
        private void OnUserAnswerToOpenQuestionRemoved(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionRemoved != null)
            {
                this.UserAnswerToOpenQuestionRemoved(a);
            }
        }
        private void OnUserAnswerToOpenQuestionUpdated(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionUpdated != null)
            {
                this.UserAnswerToOpenQuestionUpdated(a);
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> GetFields(UserAnswerToOpenQuestion answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Question_Id", answer.Question_Id);
            values.Add("Answer", answer.Answer);

            return values;
        }

        protected override Dictionary<string, object> UpdateFields(UserAnswerToOpenQuestion instance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
