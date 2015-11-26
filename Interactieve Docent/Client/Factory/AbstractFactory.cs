using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;

namespace Client.Factory
{
    public abstract class AbstractFactory
    {
        #region Instances
        private RestClient client = new RestClient();
        #endregion

        public AbstractFactory()
        {
            client.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            client.AddDefaultHeader("Content-Type", "application/json");
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
                        
            this.client.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }

        protected void findById<T>(int id, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            this.client.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }

        protected void findAll<T>(string resource, Action<List<T>> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;

            this.client.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data);
            });
        }
    }
}
