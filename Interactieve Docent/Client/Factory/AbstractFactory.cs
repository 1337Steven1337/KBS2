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

        #region Constructors
        public AbstractFactory()
        {
            this.restClient.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            this.restClient.AddDefaultHeader("Content-Type", "application/json");

            this.signalRClient = SignalRClient.getInstance();
        }
        #endregion

        #region Thread unaware methods
        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <param name="id">Instance ID</param>
        /// <param name="resource">Resource name of the model</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void deleteAsync<T>(int id, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.AddParameter("Id", id);
            request.Resource = resource;
            request.Method = Method.DELETE;

            this.restClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data);
                }
            });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <param name="data">Data to save in the database</param>
        /// <param name="resource">Resource name of the model</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void saveAsync<T>(Dictionary<String, object> data, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.Method = Method.POST;

            foreach (KeyValuePair<string, object> entry in data)
            {
                request.AddParameter(entry.Key, entry.Value);
            }

            this.restClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data);
                }
            });
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="resource">Resource name of the model</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void findByIdAsync<T>(int id, string resource, Action<T> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            this.restClient.ExecuteAsync<T>(request, response => {
                callback(response.Data);
            });
        }

        /// <summary>
        /// Finds all the instances of a model
        /// </summary>
        /// <typeparam name="T">The type of the model</typeparam>
        /// <param name="resource">Resource name of the model</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void findAllAsync<T>(string resource, Action<List<T>> callback) where T : new()
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;

            this.restClient.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data);
            });
        }
        #endregion

        #region Thread aware method
        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <typeparam name="T">The type of the model</typeparam>
        /// <param name="id">The ID of the instance</param>
        /// <param name="resource">The resource name of the model</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void delete<T>(int id, string resource, Control control, Action<T> callback) where T : new()
        {
            this.deleteAsync<T>(id, resource, o =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <typeparam name="T">The type of the model</typeparam>
        /// <param name="data">The data to save</param>
        /// <param name="resource">The resource name of the model</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void save<T>(Dictionary<String, object> data, string resource, Control control, Action<T> callback) where T : new()
        {
            this.saveAsync<T>(data, resource, o =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Finds an instance of the model by id
        /// </summary>
        /// <typeparam name="T">The type of the model</typeparam>
        /// <param name="id">The ID of the instance to find</param>
        /// <param name="resource">The resource name of the model</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void findById<T>(int id, string resource, Control control, Action<T> callback) where T : new()
        {
            this.findByIdAsync<T>(id, resource, o =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <typeparam name="T">The type of the model</typeparam>
        /// <param name="resource">The resource name of the model</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        protected void findAll<T>(string resource, Control control, Action<List<T>> callback) where T : new()
        {
            this.findAllAsync<T>(resource, o =>
            {
                control.Invoke(callback, o);
            });
        }
        #endregion
    }
}
