using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory<QuestionList>
    {
        #region Delegates
        public delegate void QuestionListAdded(QuestionList list);
        public delegate void QuestionListRemoved(QuestionList list);
        public delegate void QuestionListUpdated(QuestionList list);
        #endregion

        #region Events
        public event QuestionListAdded questionListAdded;
        public event QuestionListRemoved questionListRemoved;
        public event QuestionListUpdated questionListUpdated;
        #endregion

        #region Properties
        protected override string resource
        {
            get
            {
                return "QuestionLists";
            }
        }
        #endregion

        #region Constructors
        public QuestionListFactory()
        {
            this.signalRClient.proxy.On<QuestionList>("QuestionListAdded", this.onQuestionListAdded);
            this.signalRClient.proxy.On<QuestionList>("QuestionListRemoved", this.onQuestionListRemoved);
            this.signalRClient.proxy.On<QuestionList>("QuestionListUpdated", this.onQuestionListUpdated);

            if (this.signalRClient.state == ConnectionState.Connected)
            {
                this.signalRClient.subscribe("lists");
            }
            else
            {
                this.signalRClient.connectionStatusChanged += SignalRClient_connectionStatusChanged;
                this.signalRClient.connect();
            }
        }
        #endregion

        #region Eventhandlers
        private void SignalRClient_connectionStatusChanged(StateChange message)
        {
            if (message.NewState == ConnectionState.Connected)
            {
                this.signalRClient.subscribe("lists");
            }
        }
        #endregion 

        #region Actions
        private void onQuestionListAdded(QuestionList q)
        {
            if (this.questionListAdded != null)
            {
                this.questionListAdded(q);
            }
        }

        private void onQuestionListRemoved(QuestionList q)
        {
            if (this.questionListRemoved != null)
            {
                this.questionListRemoved(q);
            }
        }

        private void onQuestionListUpdated(QuestionList q)
        {
            if (this.questionListUpdated != null)
            {
                this.questionListUpdated(q);
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> getFields(QuestionList list)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            return values;
        }
        #endregion
    }
}
