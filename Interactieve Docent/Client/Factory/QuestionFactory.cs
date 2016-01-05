using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;

namespace Client.Factory
{
    public class QuestionFactory : AbstractFactory<Question>
    {
        #region Delegates
        public delegate void QuestionAddedDelegate(Question question);
        public delegate void QuestionRemovedDelegate(Question question);
        public delegate void QuestionUpdatedDelegate(Question question);
        #endregion

        #region Events
        public event QuestionAddedDelegate QuestionAdded;
        public event QuestionRemovedDelegate QuestionRemoved;
        public event QuestionUpdatedDelegate QuestionUpdated;
        #endregion

        #region Properties
        protected override string Resource
        {
            get
            {
                return "Questions";
            }
        }
        #endregion

        #region Constructors
        public QuestionFactory() : base(new BaseFactory<Question>())
        {
            this.SignalRClient.proxy.On<Question>("QuestionAdded", this.OnQuestionAdded);
            this.SignalRClient.proxy.On<Question>("QuestionRemoved", this.OnQuestionRemoved);
            this.SignalRClient.proxy.On<Question>("QuestionUpdated", this.OnQuestionUpdated);
        }
        #endregion

        #region Actions
        private void OnQuestionAdded(Question q)
        {
            if (this.QuestionAdded != null)
            {
                this.QuestionAdded(q);
            }
        }
        private void OnQuestionRemoved(Question q)
        {
            if (this.QuestionRemoved != null)
            {
                this.QuestionRemoved(q);
            }
        }
        private void OnQuestionUpdated(Question q)
        {
            if (this.QuestionUpdated != null)
            {
                this.QuestionUpdated(q);
            }
        }
        #endregion


        #region Overrides
        protected override Dictionary<string, object> GetFields(Question question)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Time", question.Time);
            values.Add("Points", question.Points);
            values.Add("PredefinedAnswerCount", question.PredefinedAnswerCount);
            values.Add("List_Id", question.List_Id);

            return values;
        }

        protected override Dictionary<string, object> UpdateFields(Question question)
        {
            Dictionary<string, object> values = this.GetFields(question);
            values.Add("Id", question.Id);

            return values;
        }
        #endregion
    }
}
