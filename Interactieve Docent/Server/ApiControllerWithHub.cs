using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Server.Models;
using Server.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Server
{
    public abstract class ApiControllerWithHub<THub> : ApiController
        where THub : IHub
    {
        protected IDocentAppContext db = new ServerContext();

        public ApiControllerWithHub() { }
        public ApiControllerWithHub(IDocentAppContext context)
        {
            this.db = context;
        }

        Lazy<IHubContext> hub = new Lazy<IHubContext>(
            () => GlobalHost.ConnectionManager.GetHubContext<THub>()
        );

        protected Account GetUser()
        {
            IEnumerable<string> headerValues;
            var token = string.Empty;

            if (Request.Headers.TryGetValues("Authorization", out headerValues))
            {
                token = headerValues.FirstOrDefault();
            }

            if (token == null)
            {
                return null;
            }

            return db.Accounts.Where(a => a.Token == token).FirstOrDefault();
        }

        protected IHubContext Hub
        {
            get { return hub.Value; }
        }

        protected dynamic getSubscribed(string id)
        {
            return Hub.Clients.Group(id);
        }

        protected dynamic getSubscribed(int id)
        {
            return this.getSubscribed(id.ToString());
        }
    }
}