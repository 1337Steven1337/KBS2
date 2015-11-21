using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Server.Hubs
{
    public class EventHub : Hub
    {
        public void Subscribe(string listId)
        {
            Groups.Add(Context.ConnectionId, listId);
        }

        public void Unsubscribe(string listId)
        {
            Groups.Remove(Context.ConnectionId, listId);
        }
    }
}