using Client.Service.SignalR.EventArgs;
using Microsoft.AspNet.SignalR.Client;

namespace Client.Service.SignalR
{
    public class SignalRClient
    {
        #region Delegates
        public delegate void ConnectionStatusChangedDelegate(StateChange message);
        public delegate void SubscriptionStatusChangedDelegate(SubscriptionStatus message);
        #endregion

        #region Events
        public event ConnectionStatusChangedDelegate ConnectionStatusChanged;
        public event SubscriptionStatusChangedDelegate SubscriptionStatusChanged;
        #endregion

        private static SignalRClient INSTANCE { get; set; }

        private Model.Pincode CurrentCode { get; set; }
        private Model.Pincode ShouldSubscribeCode { get; set; }
        private bool ShouldSubscribe = false;

        private HubConnection connection { get; set; }
        public IHubProxy proxy { get; private set; }
        public ConnectionState state
        {
            get
            {
                return (this.connection == null) ? ConnectionState.Disconnected : this.connection.State;
            }
        }

        private SignalRClient()
        {
            this.connection = new HubConnection(Properties.Api.Default.Host + Properties.Api.Default.SignalR);
            this.connection.StateChanged += Connection_StateChanged;
            this.proxy = this.connection.CreateHubProxy("EventHub");
        }

        private void Connection_StateChanged(StateChange obj)
        {
            if (obj.NewState == ConnectionState.Connected)
            {
                if (this.ShouldSubscribe)
                {
                    this.SubscribePincode(this.ShouldSubscribeCode);
                    this.ShouldSubscribe = false;
                }

                this.proxy.Invoke("SubscribeToLists");
            }

            if(this.ConnectionStatusChanged != null)
            {
                this.ConnectionStatusChanged(obj);
            }
        }

        public async void SubscribePincode(Model.Pincode code)
        {
            if (this.state == ConnectionState.Connected)
            {
                if (this.CurrentCode != null)
                {
                    this.UnsubscribePincode(this.CurrentCode);
                }

                this.CurrentCode = code;
                await this.proxy.Invoke("SubscribeCode", code.Id);
            }
            else
            {
                this.ShouldSubscribe = true;
                this.ShouldSubscribeCode = code;

                if (this.state == ConnectionState.Disconnected)
                {
                    await this.connection.Start();
                }
            }
        }

        public async void UnsubscribePincode(Model.Pincode code)
        {
            if (this.state == ConnectionState.Connected)
            {
                await this.proxy.Invoke("UnsubscribeCode", code.Id);
            }
        }

        public void SubscribeList(Model.QuestionList list)
        {
            this.SubscribeList(list.Id);
        }

        public async void SubscribeList(int id)
        {
            await this.proxy.Invoke("SubscribeList", id);
        }

        public async void UnsubscribeList(Model.QuestionList list)
        {
            await this.proxy.Invoke("UnsubscribeList", list.Id);
        }

        public async void GoToNextQuestionOnClick(int id)
        {
            await this.proxy.Invoke("Next", id);
        }

        public async void StopQuestionList(int id)
        {
            await this.proxy.Invoke("Stop", id);
        }

        public async void StartQuestionList(int id, int session_Id, bool tempo)
        {
            await this.proxy.Invoke("StartQuestionList",id,session_Id,tempo);
        }

        public void Connect()
        {
            if (this.state == ConnectionState.Disconnected)
            {
                this.connection.Start();
            }
        }

        public static SignalRClient GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new SignalRClient();
            }

            return INSTANCE;
        }
    }
}
