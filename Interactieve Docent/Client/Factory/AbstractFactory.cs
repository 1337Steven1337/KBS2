using Client.Model;
using Client.Service.SignalR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Client.Factory
{
    public abstract class AbstractFactory<T> where T : AbstractModel, new()
    {
        #region Properties
        protected abstract string resource { get; }
        #endregion

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
        /// <param name="instance">The instance to delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void deleteAsync(T instance, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("Id", instance.Id);
            request.Resource = this.resource;
            request.Method = Method.DELETE;

            this.restClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void deleteAsync(T instance, Action<T, HttpStatusCode> callback)
        {
            this.deleteAsync(instance, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o, s);
                }
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void deleteAsync(T instance, Action<T> callback)
        {
            this.deleteAsync(instance, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o);
                }
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        public void deleteAsync(T instance)
        {
            this.deleteAsync(instance, (o, s, r) => { });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void saveAsync(T instance, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;
            request.Method = Method.POST;

            foreach (KeyValuePair<string, object> entry in this.getFields(instance))
            {
                request.AddParameter(entry.Key, entry.Value);
            }

            this.restClient.ExecuteAsync<T>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void saveAsync(T instance, Action<T, HttpStatusCode> callback)
        {
            this.saveAsync(instance, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o, s);
                }
            });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void saveAsync(T instance, Action<T> callback)
        {
            this.saveAsync(instance, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o);
                }
            });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to save</param>
        public void saveAsync(T instance)
        {
            this.saveAsync(instance, (o, s, r) => {});
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findByIdAsync(int id, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = this.resource;
            request.AddParameter("Id", id);

            this.restClient.ExecuteAsync<T>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findByIdAsync(int id, Action<T, HttpStatusCode> callback)
        {
            this.findByIdAsync(id, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o, s);
                }
            });
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findByIdAsync(int id, Action<T> callback)
        {
            this.findByIdAsync(id, (o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o);
                }
            });
        }

        /// <summary>
        /// Finds all the instances of a model
        /// </summary>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAllAsync(Action<List<T>, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = resource;

            this.restClient.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }

        /// <summary>
        /// Finds all the instances of a model
        /// </summary>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAllAsync(Action<List<T>, HttpStatusCode> callback)
        {
            this.findAllAsync((o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o, s);
                }
            });
        }

        /// <summary>
        /// Finds all the instances of a model
        /// </summary>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAllAsync(Action<List<T>> callback)
        {
            this.findAllAsync((o, s, r) =>
            {
                if (callback != null)
                {
                    callback(o);
                }
            });
        }
        #endregion

        #region Thread aware method
        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void delete(T instance, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.deleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s, r);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void delete(T instance, Control control, Action<T, HttpStatusCode> callback)
        {
            this.deleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void delete(T instance, Control control, Action<T> callback)
        {
            this.deleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void delete(T instance)
        {
            this.deleteAsync(instance);
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void save(T instance, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.saveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o,s ,r);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void save(T instance, Control control, Action<T, HttpStatusCode> callback)
        {
            this.saveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void save(T instance, Control control, Action<T> callback)
        {
            this.saveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void save(T instance)
        {
            this.saveAsync(instance);
        }

        /// <summary>
        /// Finds an instance of the model by id
        /// </summary>
        /// <param name="id">The ID of the instance to find</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findById(int id, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.findByIdAsync(id, (o, s, r) =>
            {
                control.Invoke(callback, o, s, r);
            });
        }

        /// <summary>
        /// Finds an instance of the model by id
        /// </summary>
        /// <param name="id">The ID of the instance to find</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findById(int id, Control control, Action<T, HttpStatusCode> callback)
        {
            this.findByIdAsync(id, (o, s, r) =>
            {
                control.Invoke(callback, o, s);
            });
        }

        /// <summary>
        /// Finds an instance of the model by id
        /// </summary>
        /// <param name="id">The ID of the instance to find</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findById(int id, Control control, Action<T> callback)
        {
            this.findByIdAsync(id, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAll(Control control, Action<List<T>, HttpStatusCode, IRestResponse> callback)
        {
            this.findAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o, r, s);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAll(Control control, Action<List<T>, HttpStatusCode> callback)
        {
            this.findAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o, r);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void findAll(Control control, Action<List<T>> callback)
        {
            this.findAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o);
            });
        }
        #endregion

        #region Methods
        protected abstract Dictionary<string, object> getFields(T answer);
        #endregion
    }
}
