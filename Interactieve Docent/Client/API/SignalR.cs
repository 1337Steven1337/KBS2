using Client.API.EventArgs;
using Client.API.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    public class SignalR
    {
        #region Delegates
        public delegate void ConnectionStatusChanged(StateChange message);
        public delegate void SubscriptionStatusChanged(SubscriptionStatus message);
        public delegate void NewQuestionAdded(Question question);
        #endregion

        #region Events
        public event ConnectionStatusChanged connectionStatusChanged;
        public event SubscriptionStatusChanged subscriptionStatusChanged;
        public event NewQuestionAdded newQuestionAdded;
        #endregion

        #region Properties
        private IHubProxy proxy { get; set; }
        private HubConnection connection { get; set; }

        private int subscribed = -1;
        #endregion

        #region Methods
        /// <summary>
        /// Connects to the SignalR endpoint on the server
        /// </summary>
        public async void connect()
        {
            this.connection = new HubConnection(Properties.Api.Default.Host + Properties.Api.Default.SignalR);
            this.connection.StateChanged += Connection_StateChanged;

            this.proxy = this.connection.CreateHubProxy("EventHub");

            this.proxy.On<Question>("QuestionAdded", this.onQuestionAdded);

            try
            {
                await this.connection.Start();
            }
            catch(HttpRequestException)
            {
                Console.WriteLine("Could not connect to the signalR server");
            }
        }

        /// <summary>
        /// Subscribes to a list on the server
        /// </summary>
        /// <param name="id">The id of the list to subscribe to</param>
        public async void subscribe(int id)
        {
            if (this.subscribed > 0)
            {
                this.unsubscribe(this.subscribed);
            }

            this.subscribed = id;
            await this.proxy.Invoke("Subscribe", this.subscribed);

            if(this.subscriptionStatusChanged != null)
            {
                this.subscriptionStatusChanged(new SubscriptionStatus(this.subscribed));
            }
        }

        /// <summary>
        /// Unsubscribe from a list on the server
        /// </summary>
        /// <param name="id">The id of the list to unsubscribe from</param>
        public async void unsubscribe(int id)
        {
            this.subscribed = -1;
            await this.proxy.Invoke("Unsubscribe", id);
        }

        /// <summary>
        /// Calls the question added event
        /// </summary>
        /// <param name="q">The question which was added to the list</param>
        private void onQuestionAdded(Question q)
        {
            if(this.newQuestionAdded != null)
            {
                this.newQuestionAdded(q);
            }
        }

        /// <summary>
        /// Calls the connectionStateChanged event
        /// </summary>
        /// <param name="obj">The object with the relevant fields</param>
        private void Connection_StateChanged(StateChange obj)
        {
            if(this.connectionStatusChanged != null)
            {
                this.connectionStatusChanged(obj);
            }
        }
        #endregion
    }
}
