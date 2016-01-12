using Client.Model;
using Client.Service.Login;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace Client.Factory
{
    public class BaseFactory<T> : IFactory<T> where T : AbstractModel, new()
    {
        #region Properties
        private RestClient RestClient = new RestClient();
        private LoginClient LoginClient;
        private string Resource;
        #endregion

        #region Constructors
        public BaseFactory() : this(true) {}

        public BaseFactory(bool requireLogin)
        {
            this.RestClient.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            this.RestClient.AddDefaultHeader("Content-Type", "application/json");

            if (requireLogin)
            {
                this.LoginClient = LoginClient.GetInstance();

                if(this.LoginClient.GetToken() == null)
                {
                    this.LoginClient.CredentialsChanged += LoginClient_CredentialsChanged;
                }
                else
                {
                    this.RestClient.AddDefaultHeader("Authorization", this.LoginClient.GetToken());
                }
            }
        }
        #endregion

        #region Actions
        private void LoginClient_CredentialsChanged(string token)
        {
            this.RestClient.AddDefaultHeader("Authorization", token);
            this.LoginClient.CredentialsChanged -= LoginClient_CredentialsChanged;
        }
        #endregion

        #region Setters
        public void SetResource(string resource)
        {
            this.Resource = resource;
        }
        #endregion

        #region Factory methods
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
        #endregion

        #region UnimplementedException
        public void ExecuteAsync<C>(IRestRequest request, Action<IRestResponse<C>> callback) where C : new()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
