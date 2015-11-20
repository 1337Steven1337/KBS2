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
        public delegate void ConnectionStatusChanged(StateChange message);
        public delegate void SubscriptionStatusChanged(SubscriptionStatus message);
        public delegate void NewQuestionAdded(Question question);

        public event ConnectionStatusChanged connectionStatusCHanged;
        public event SubscriptionStatusChanged subscriptionStatusChanged;
        public event NewQuestionAdded newQuestionAdded;

        private IHubProxy proxy { get; set; }
        private HubConnection connection { get; set; }

        private int subscribed = -1;

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

        public async void unsubscribe(int id)
        {
            this.subscribed = -1;
            await this.proxy.Invoke("Unsubscribe", id);
        }

        private void onQuestionAdded(Question q)
        {
            if(this.newQuestionAdded != null)
            {
                this.newQuestionAdded(q);
            }
        }

        private void Connection_StateChanged(StateChange obj)
        {
            if(this.connectionStatusCHanged != null)
            {
                this.connectionStatusCHanged(obj);
            }
        }
    }
}
