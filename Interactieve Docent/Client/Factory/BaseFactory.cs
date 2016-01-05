using Client.Factory;
using Client.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.Factory
{
    public class BaseFactory<T> : IFactory<T> where T : AbstractModel, new()
    {
        private RestClient RestClient = new RestClient();
        private string Resource;

        public BaseFactory()
        {
            this.RestClient.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            this.RestClient.AddDefaultHeader("Content-Type", "application/json");
        }

        public void SetResource(string resource)
        {
            this.Resource = resource;
        } 

        public void UpdateAsync(List<KeyValuePair<string, object>> data, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = Resource;
            request.Method = Method.PUT;

            foreach (KeyValuePair<string, object> entry in data)
            {
                if (entry.Key == "Id")
                {
                    request.Resource = Resource + "/" + Convert.ToInt32(entry.Value);
                }

                request.AddParameter(entry.Key, entry.Value);
                
            }

            this.RestClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }

        public void DeleteAsync(T instance, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("Id", instance.Id);
            request.Resource = this.Resource;
            request.Method = Method.DELETE;

            this.RestClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }
        public void SaveAsync(List<KeyValuePair<string, object>> data, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = Resource;
            request.Method = Method.POST;

            foreach (KeyValuePair<string, object> entry in data)
            {
                request.AddParameter(entry.Key, entry.Value);
            }

            this.RestClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }
        public void FindByIdAsync(object id, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = this.Resource;
            request.AddParameter("Id", id);

            this.RestClient.ExecuteAsync<T>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }


        public void FindAllAsync(Action<List<T>, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = this.Resource;

            this.RestClient.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }

        public void ExecuteAsync<C>(IRestRequest request, Action<IRestResponse<C>> callback) where C : new()
        {
            throw new NotImplementedException();
        }
    }
}
