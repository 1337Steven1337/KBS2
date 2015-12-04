using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;

namespace Client.Factory
{
    public class QuestionFactory : AbstractFactory<Question>
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

        #region Properties
        protected override string resource
        {
            get
            {
                return "Questions";
            }
        }
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

        #region Overrides
        protected override Dictionary<string, object> getFields(Question question)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Time", question.Time);
            values.Add("Points", question.Points);
            values.Add("PredefinedAnswerCount", question.PredefinedAnswerCount);
            values.Add("List_Id", question.List_Id);

            return values;
        }
        #endregion
    }
}
