using Client.Service.SignalR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public abstract class AbstractFactory
    {
        #region Instances
        private RestClient restClient = new RestClient();
        protected SignalRClient signalRClient = null;
        #endregion

        public AbstractFactory()
        {
            this.restClient.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            this.restClient.AddDefaultHeader("Content-Type", "application/json");

            this.signalRClient = SignalRClient.getInstance();
        }

        protected void save<T>(Dictionary<String, object> data, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.Method = Method.POST;

            foreach(KeyValuePair<string, object> entry in data)
            {
                request.AddParameter(entry.Key, entry.Value);
            }
                        
            this.restClient.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }

        protected void findById<T>(int id, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            this.restClient.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }

        protected void findAll<T>(string resource, Control control, Action<List<T>> callback) where T : new()
        {
            this.findAllAsync<T>(resource, o =>
            {
                control.Invoke(callback, o);
            });
        }

        protected void findAllAsync<T>(string resource, Action<List<T>> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;

            this.restClient.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data);
            });
        }
    }
}
