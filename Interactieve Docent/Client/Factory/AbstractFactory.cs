using RestSharp;
using System;
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

        public void getById<T>(int id, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            this.client.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }
    }
}
