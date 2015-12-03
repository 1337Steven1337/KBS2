using Client.Service.SignalR.EventArgs;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Client.Service.SignalR
{
    public class SignalRClient
    {
        #region Delegates
        public delegate void ConnectionStatusChanged(StateChange message);
        public delegate void SubscriptionStatusChanged(SubscriptionStatus message);
        #endregion

        #region Events
        public event ConnectionStatusChanged connectionStatusChanged;
        public event SubscriptionStatusChanged subscriptionStatusChanged;
        #endregion

        #region Properties
        private List<object> subscribeQueue = new List<object>();
        private static SignalRClient client { get; set; }

        private HubConnection connection { get; set; }
        public IHubProxy proxy { get; private set; }
        public ConnectionState state
        {
            get
            {
                return (this.connection == null) ? ConnectionState.Disconnected : this.connection.State;
            }
        }
        #endregion

        #region Constructors
        private SignalRClient()
        {
            this.connection = new HubConnection(Properties.Api.Default.Host + Properties.Api.Default.SignalR);
            this.proxy = this.connection.CreateHubProxy("EventHub");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Connects to the SignalR endpoint on the server
        /// </summary>
        public async void connect()
        {
            if (this.state != ConnectionState.Connected && this.state != ConnectionState.Connecting)
            {
                this.connection.StateChanged += Connection_StateChanged;

                try
                {
                    await this.connection.Start();
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Could not connect to the signalR server");
                }
            }
        }

        /// <summary>
        /// Subscribes to a list on the server
        /// </summary>
        /// <param name="id">The id of the list to subscribe to</param>
        public void subscribe(int id)
        {
            this.subscribe((object)id);
        }

        public void subscribe(string id)
        {
            this.subscribe((object)id);
        }

        public async void subscribe(object id)
        {
            this.connectionStatusChanged -= SignalRClient_connectionStatusChanged;

            if (this.state == ConnectionState.Connected)
            {
                await this.proxy.Invoke("Subscribe", id);

                if (this.subscriptionStatusChanged != null)
                {
                    this.subscriptionStatusChanged(new SubscriptionStatus(id));
                }
            }
            else
            {
                if (this.subscribeQueue.Count == 0)
                {
                    this.connectionStatusChanged += SignalRClient_connectionStatusChanged;
                }

                this.subscribeQueue.Add(id);
            }

        }

        private void SignalRClient_connectionStatusChanged(StateChange message)
        {
            if (this.subscribeQueue.Count > 0 && message.NewState == ConnectionState.Connected)
            {
                foreach (object o in this.subscribeQueue)
                {
                    this.subscribe(o);
                }
            }
        }

        /// <summary>
        /// Unsubscribe from a list on the server
        /// </summary>
        /// <param name="id">The id of the list to unsubscribe from</param>
        public async void unsubscribe(int id)
        {
            await this.proxy.Invoke("Unsubscribe", id);
        }

        /// <summary>
        /// Calls the connectionStateChanged event
        /// </summary>
        /// <param name="obj">The object with the relevant fields</param>
        private void Connection_StateChanged(StateChange obj)
        {
            if (this.connectionStatusChanged != null)
            {
                this.connectionStatusChanged(obj);
            }
        }

        public static SignalRClient getInstance()
        {
            if(SignalRClient.client == null)
            {
                SignalRClient.client = new SignalRClient();
            }

            return SignalRClient.client;
        }
        #endregion
    }
}
