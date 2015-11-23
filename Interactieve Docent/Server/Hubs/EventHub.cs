using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Server.Hubs
{
    public class EventHub : Hub
    {
        /// <summary>
        /// Subscribe point for the client, when the client is subscribed it will receive events
        /// </summary>
        /// <param name="listId">The list ID to subscribe to</param>
        public void Subscribe(string listId)
        {
            Groups.Add(Context.ConnectionId, listId);
        }

        /// <summary>
        /// Unsubscribe point for the client, the client will stop receiving the events for the list
        /// </summary>
        /// <param name="listId">The list ID to unsubscribe from</param>
        public void Unsubscribe(string listId)
        {
            Groups.Remove(Context.ConnectionId, listId);
        }
    }
}