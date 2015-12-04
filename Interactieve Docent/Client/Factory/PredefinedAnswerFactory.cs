using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class PredefinedAnswerFactory : AbstractFactory<PredefinedAnswer>
    {
        #region Delegates
        public delegate void PredefinedAnswerAdded(PredefinedAnswer answer);
        public delegate void PredefinedAnswerRemoved(PredefinedAnswer answer);
        public delegate void PredefinedAnswerUpdated(PredefinedAnswer answer);
        #endregion

        #region Events
        public event PredefinedAnswerAdded predefinedAnswerAdded;
        public event PredefinedAnswerRemoved predefinedAnswerRemoved;
        public event PredefinedAnswerUpdated predefinedAnswerUpdated;
        #endregion

        #region Properties
        protected override string resource
        {
            get
            {
                return "PredefinedAnswers";
            }
        }
        #endregion

        #region Constructors
        public PredefinedAnswerFactory()
        {
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerAdded", this.onPredefinedAnswerAdded);
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerRemoved", this.onPredefinedAnswerRemoved);
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerUpdated", this.onPredefinedAnswerUpdated);
        }
        #endregion

        #region Actions
        private void onPredefinedAnswerAdded(PredefinedAnswer a)
        {
            if (this.predefinedAnswerAdded != null)
            {
                this.predefinedAnswerAdded(a);
            }
        }

        private void onPredefinedAnswerRemoved(PredefinedAnswer a)
        {
            if (this.predefinedAnswerRemoved != null)
            {
                this.predefinedAnswerRemoved(a);
            }
        }

        private void onPredefinedAnswerUpdated(PredefinedAnswer a)
        {
            if (this.predefinedAnswerUpdated != null)
            {
                this.predefinedAnswerUpdated(a);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Prepares the entity to save it
        /// </summary>
        /// <param name="answer">The answer to save</param>
        /// <returns>Dictonary containing the values used to save the entity</returns>
        protected override Dictionary<string, object> getFields(PredefinedAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);
            values.Add("Question_Id", answer.Question_Id);
            values.Add("Right_Answer", answer.RightAnswer);
            return values;
        }
        #endregion
    }
}
