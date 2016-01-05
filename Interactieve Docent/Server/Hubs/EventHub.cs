using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Server.Hubs
{
    public class EventHub : Hub
    {
        public void SubscribeCode(string code)
        {
            Groups.Add(Context.ConnectionId, "Code-" + code);
        } 

        public void UnsubscribeCode(string code)
        {
            Groups.Remove(Context.ConnectionId, "Code-" + code);
        }

        public void SubscribeList(int id)
        {
            Groups.Add(Context.ConnectionId, "List-" + id);
        }

        public void UnsubscribeList(int id)
        {
            Groups.Remove(Context.ConnectionId, "List-" + id);
        }

        public void SubscribeToLists()
        {
            Groups.Add(Context.ConnectionId, "Misc-Lists");
        }
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

        /// <summary>
        /// Send the clients the event to continue to the next question
        /// </summary>
        /// <param name="listId">The list ID to proceed with</param>
        public void Next(string listId)
        {
            Clients.Group(listId).QuestionListContinue();
        }

        /// <summary>
        /// Send the clients the event to continue to the next question
        /// </summary>
        /// <param name="listId">The list ID to proceed with</param>
        public void StartQuestionList(int listId, int sessionId)
        {
            Clients.Group("Code-" + sessionId.ToString()).QuestionListStarted(listId);
        }
    }
}