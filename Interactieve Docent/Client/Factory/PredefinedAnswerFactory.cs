 using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;
using System;

namespace Client.Factory
{
    public class PredefinedAnswerFactory : AbstractFactory<PredefinedAnswer>
    {
        #region Delegates
        public delegate void PredefinedAnswerAddedDelegate(PredefinedAnswer answer);
        public delegate void PredefinedAnswerRemovedDelegate(PredefinedAnswer answer);
        public delegate void PredefinedAnswerUpdatedDelegate(PredefinedAnswer answer);
        #endregion

        #region Events
        public event PredefinedAnswerAddedDelegate PredefinedAnswerAdded;
        public event PredefinedAnswerRemovedDelegate PredefinedAnswerRemoved;
        public event PredefinedAnswerUpdatedDelegate PredefinedAnswerUpdated;
        #endregion

        #region Properties
        protected override string Resource
        {
            get
            {
                return "PredefinedAnswers";
            }
        }
        #endregion

        #region Constructors
        public PredefinedAnswerFactory() : base(new BaseFactory<PredefinedAnswer>())
        {
            this.SignalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerAdded", this.OnPredefinedAnswerAdded);
            this.SignalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerRemoved", this.OnPredefinedAnswerRemoved);
            this.SignalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerUpdated", this.OnpredefinedAnswerUpdated);
        }
        #endregion

        #region Actions
        private void OnPredefinedAnswerAdded(PredefinedAnswer a)
        {
            if (this.PredefinedAnswerAdded != null)
            {
                this.PredefinedAnswerAdded(a);
            }
        }
        private void OnPredefinedAnswerRemoved(PredefinedAnswer a)
        {
            if (this.PredefinedAnswerRemoved != null)
            {
                this.PredefinedAnswerRemoved(a);
            }
        }
        private void OnpredefinedAnswerUpdated(PredefinedAnswer a)
        {
            if (this.PredefinedAnswerUpdated != null)
            {
                this.PredefinedAnswerUpdated(a);
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> GetFields(PredefinedAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);
            values.Add("Question_Id", answer.Question_Id);
            values.Add("Right_Answer", answer.RightAnswer);
            return values;
        }

        protected override Dictionary<string, object> UpdateFields(PredefinedAnswer instance)
        {
            Dictionary<string, object> values = this.GetFields(instance);
            values.Add("Id", instance.Id);

            return values;
        }
        #endregion
    }
}
