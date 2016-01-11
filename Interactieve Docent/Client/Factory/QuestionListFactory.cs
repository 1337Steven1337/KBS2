using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Collections.Generic;
using System;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory<QuestionList>
    {
        #region Delegates
        public delegate void QuestionListAddedDelegate(QuestionList list);
        public delegate void QuestionListRemovedDelegate(QuestionList list);
        public delegate void QuestionListUpdatedDelegate(QuestionList list);
        public delegate void QuestionListContinueDelegate();
        public delegate void QuestionListStartedDelegate(int listId);
        public delegate void QuestionListStoppedDelegate();
        #endregion

        #region Events
        public event QuestionListAddedDelegate QuestionListAdded;
        public event QuestionListStartedDelegate QuestionListStarted;
        public event QuestionListRemovedDelegate QuestionListRemoved;
        public event QuestionListUpdatedDelegate QuestionListUpdated;
        public event QuestionListContinueDelegate QuestionListContinue;
        public event QuestionListStoppedDelegate QuestionListStopped;
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
        public QuestionListFactory() : base(new BaseFactory<QuestionList>())
        {
            this.SignalRClient.proxy.On<QuestionList>("QuestionListAdded", this.OnQuestionListAdded);
            this.SignalRClient.proxy.On<QuestionList>("QuestionListRemoved", this.OnQuestionListRemoved);
            this.SignalRClient.proxy.On<QuestionList>("QuestionListUpdated", this.OnQuestionListUpdated);
            this.SignalRClient.proxy.On("QuestionListContinue", this.OnQuestionListContinue);
            this.SignalRClient.proxy.On<int>("QuestionListStarted", this.OnQuestionListStarted);
            this.SignalRClient.proxy.On("QuestionListStopped", this.OnQuestionListStopped);
            this.SignalRClient.Connect();
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
        private void OnQuestionListStarted(int listId)
        {
            if (this.QuestionListStarted != null)
            {
                this.QuestionListStarted(listId);
            }
        }
        private void OnQuestionListStopped()
        {
            if (this.QuestionListStopped != null)
            {
                this.QuestionListStopped();
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

        protected override Dictionary<string, object> UpdateFields(QuestionList instance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
