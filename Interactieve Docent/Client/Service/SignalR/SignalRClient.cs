using Client.Service.SignalR.EventArgs;
using Microsoft.AspNet.SignalR.Client;
using System;
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
        private int subscribed = -1;
        private static SignalRClient client { get; set; }

        private HubConnection connection { get; set; }
        public IHubProxy proxy { get; private set; }
        #endregion

        #region Constructors
        private SignalRClient()
        {

        }
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

            try
            {
                await this.connection.Start();
            }
            catch (HttpRequestException)
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

            if (this.subscriptionStatusChanged != null)
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
