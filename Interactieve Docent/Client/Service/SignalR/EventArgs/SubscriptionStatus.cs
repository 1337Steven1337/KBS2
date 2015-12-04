namespace Client.Service.SignalR.EventArgs
{
    public class SubscriptionStatus
    {
        public object Id { get; private set;  } 

        public SubscriptionStatus(object id)
        {
            this.Id = id;
        }
    }
}
