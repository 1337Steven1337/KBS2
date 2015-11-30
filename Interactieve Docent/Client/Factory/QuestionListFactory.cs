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

        public void delete(QuestionList list, Control control, Action<QuestionList> callback)
        {
            this.delete<QuestionList>(list.Id, resource, control, callback);
        }

        public void deleteAsync(QuestionList list, Action<QuestionList> callback)
        {
            this.deleteAsync<QuestionList>(list.Id, resource, callback);
        }

        private Dictionary<string, object> getFields(QuestionList list)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            return values;
        }

        public void saveAsync(QuestionList list, Action<QuestionList> callback)
        {
            this.saveAsync<QuestionList>(this.getFields(list), resource, callback);
        }

        public void save(QuestionList list, Control control, Action<QuestionList> callback)
        {
            this.save<QuestionList>(this.getFields(list), resource, control, callback);
        }

        public void findByIdAsync(int id, Action<QuestionList> callback)
        {
            this.findByIdAsync<QuestionList>(id, resource, callback);
        }

        public void findById(int id, Control control, Action<QuestionList> callback)
        {
            this.findById<QuestionList>(id, resource, control, callback);
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
