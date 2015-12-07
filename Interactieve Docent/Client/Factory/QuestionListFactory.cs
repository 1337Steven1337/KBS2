using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory<QuestionList>
    {
        #region Delegates
        public delegate void QuestionListAddedDelegate(QuestionList list);
        public delegate void QuestionListRemovedDelegate(QuestionList list);
        public delegate void QuestionListUpdatedDelegate(QuestionList list);
        public delegate void QuestionListContinueDelegate();
        #endregion

        #region Events
        public event QuestionListAddedDelegate QuestionListAdded;
        public event QuestionListRemovedDelegate QuestionListRemoved;
        public event QuestionListUpdatedDelegate QuestionListUpdated;
        public event QuestionListContinueDelegate QuestionListContinue;
        #endregion

        #region Properties
        protected override string Resource
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
            this.SignalRClient.proxy.On<QuestionList>("QuestionListAdded", this.OnQuestionListAdded);
            this.SignalRClient.proxy.On<QuestionList>("QuestionListRemoved", this.OnQuestionListRemoved);
            this.SignalRClient.proxy.On<QuestionList>("QuestionListUpdated", this.OnQuestionListUpdated);
            this.SignalRClient.proxy.On("QuestionListContinue", this.OnQuestionListContinue);

            if (this.SignalRClient.state == ConnectionState.Connected)
            {
                this.SignalRClient.Subscribe("lists");
            }
            else
            {
                this.SignalRClient.connectionStatusChanged += SignalRClient_connectionStatusChanged;
                this.SignalRClient.Connect();
            }
        }
        #endregion

        #region Eventhandlers
        private void SignalRClient_connectionStatusChanged(StateChange message)
        {
            if (message.NewState == ConnectionState.Connected)
            {
                this.SignalRClient.Subscribe("lists");
            }
        }
        #endregion 

        #region Actions
        private void OnQuestionListAdded(QuestionList q)
        {
            if (this.QuestionListAdded != null)
            {
                this.QuestionListAdded(q);
            }
        }
        private void OnQuestionListRemoved(QuestionList q)
        {
            if (this.QuestionListRemoved != null)
            {
                this.QuestionListRemoved(q);
            }
        }
        private void OnQuestionListUpdated(QuestionList q)
        {
            if (this.QuestionListUpdated != null)
            {
                this.QuestionListUpdated(q);
            }
        }
        private void OnQuestionListContinue()
        {
            if (this.QuestionListContinue != null)
            {
                this.QuestionListContinue();
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> GetFields(QuestionList list)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            return values;
        }
        #endregion
    }
}
