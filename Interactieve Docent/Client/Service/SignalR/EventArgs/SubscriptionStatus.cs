using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service.SignalR.EventArgs
{
    public class SubscriptionStatus
    {
        public object id; 

        public SubscriptionStatus(object id)
        {
            this.id = id;
        }
    }
}
