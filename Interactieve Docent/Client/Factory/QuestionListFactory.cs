using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory
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

        #region Constants
        private const string resource = "QuestionLists";
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

        private void SignalRClient_connectionStatusChanged(StateChange message)
        {
            if(message.NewState == ConnectionState.Connected)
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

        public void saveAsync(QuestionList list, Action<QuestionList> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            this.saveAsync<QuestionList>(values, resource, callback);
        }

        public void save(QuestionList list, Control control, Action<QuestionList> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            this.save<QuestionList>(values, resource, control, callback);
        }

        public void findById(int id, Action<QuestionList> callback)
        {
            this.findById<QuestionList>(id, resource, callback);
        }

        public void findAll(Control control, Action<List<QuestionList>> callback)
        {
            this.findAll<QuestionList>(resource, control, callback);
        }

        public void findAllAsync(Action<List<QuestionList>> callback)
        {
            this.findAllAsync<QuestionList>(resource, callback);
        }
    }
}
