using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service.SignalR.EventArgs
{
    public class SubscriptionStatus
    {
        public int id;

        public SubscriptionStatus(int id)
        {
            this.id = id;
        }
    }
}
