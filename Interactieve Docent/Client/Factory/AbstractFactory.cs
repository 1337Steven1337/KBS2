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
        protected abstract string Resource { get; }
        #endregion

        #region Instances
        private RestClient RestClient = new RestClient();
        protected SignalRClient SignalRClient = null;
        #endregion

        #region Constructors
        public AbstractFactory()
        {
            this.RestClient.BaseUrl = new Uri(Properties.Api.Default.Host + Properties.Api.Default.Rest);
            this.RestClient.AddDefaultHeader("Content-Type", "application/json");

            this.SignalRClient = SignalRClient.GetInstance();
        }
        #endregion

        #region Thread unaware methods
        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to Delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
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

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to Delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void DeleteAsync(T instance, Action<T, HttpStatusCode> callback)
        {
            this.DeleteAsync(instance, (o, s, r) =>
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
        /// <param name="instance">The instance to Delete</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void DeleteAsync(T instance, Action<T> callback)
        {
            this.DeleteAsync(instance, (o, s, r) =>
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
        /// <param name="instance">The instance to Delete</param>
        public void DeleteAsync(T instance)
        {
            this.DeleteAsync(instance, (o, s, r) => { });
        }

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void SaveAsync(T instance, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = Resource;
            request.Method = Method.POST;

            foreach (KeyValuePair<string, object> entry in this.GetFields(instance))
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

        /// <summary>
        /// Saves an instance to the database
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void SaveAsync(T instance, Action<T, HttpStatusCode> callback)
        {
            this.SaveAsync(instance, (o, s, r) =>
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
        /// <param name="instance">The instance to Save</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void SaveAsync(T instance, Action<T> callback)
        {
            this.SaveAsync(instance, (o, s, r) =>
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
        /// <param name="instance">The instance to Save</param>
        public void SaveAsync(T instance)
        {
            this.SaveAsync(instance, (o, s, r) => {});
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindByIdAsync(int id, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = this.Resource;
            request.AddParameter("Id", id);

            this.RestClient.ExecuteAsync<T>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }

        /// <summary>
        /// Finds an instance of model from the database by id
        /// </summary>
        /// <param name="id">The ID of the instance you want to find</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindByIdAsync(int id, Action<T, HttpStatusCode> callback)
        {
            this.FindByIdAsync(id, (o, s, r) =>
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
        public void FindByIdAsync(int id, Action<T> callback)
        {
            this.FindByIdAsync(id, (o, s, r) =>
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
        public void FindAllAsync(Action<List<T>, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = Resource;

            this.RestClient.ExecuteAsync<List<T>>(request, response => {
                callback(response.Data, response.StatusCode, response);
            });
        }

        /// <summary>
        /// Finds all the instances of a model
        /// </summary>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindAllAsync(Action<List<T>, HttpStatusCode> callback)
        {
            this.FindAllAsync((o, s, r) =>
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
        public void FindAllAsync(Action<List<T>> callback)
        {
            this.FindAllAsync((o, s, r) =>
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
        /// <param name="instance">The instance to Delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Delete(T instance, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.DeleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s, r);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to Delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Delete(T instance, Control control, Action<T, HttpStatusCode> callback)
        {
            this.DeleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to Delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Delete(T instance, Control control, Action<T> callback)
        {
            this.DeleteAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Deletes an instance from the database
        /// </summary>
        /// <param name="instance">The instance to Delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Delete(T instance)
        {
            this.DeleteAsync(instance);
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Save(T instance, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.SaveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o,s ,r);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Save(T instance, Control control, Action<T, HttpStatusCode> callback)
        {
            this.SaveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o, s);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Save(T instance, Control control, Action<T> callback)
        {
            this.SaveAsync(instance, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Saves an instance of the model
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void Save(T instance)
        {
            this.SaveAsync(instance);
        }

        /// <summary>
        /// Finds an instance of the model by id
        /// </summary>
        /// <param name="id">The ID of the instance to find</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindById(int id, Control control, Action<T, HttpStatusCode, IRestResponse> callback)
        {
            this.FindByIdAsync(id, (o, s, r) =>
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
        public void FindById(int id, Control control, Action<T, HttpStatusCode> callback)
        {
            this.FindByIdAsync(id, (o, s, r) =>
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
        public void FindById(int id, Control control, Action<T> callback)
        {
            this.FindByIdAsync(id, (o, s, r) =>
            {
                control.Invoke(callback, o);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindAll(Control control, Action<List<T>, HttpStatusCode, IRestResponse> callback)
        {
            this.FindAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o, r, s);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindAll(Control control, Action<List<T>, HttpStatusCode> callback)
        {
            this.FindAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o, r);
            });
        }

        /// <summary>
        /// Find all instances of a model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">Callback which is called when the request is completed</param>
        public void FindAll(Control control, Action<List<T>> callback)
        {
            this.FindAllAsync((o, r, s) =>
            {
                control.Invoke(callback, o);
            });
        }
        #endregion

        #region Methods
        /// <summary>
        /// Prepares the instance to Save it
        /// </summary>
        /// <param name="instance">The instance to Save</param>
        /// <returns>Dictonary containing the values used to Save the instance</returns>
        protected abstract Dictionary<string, object> GetFields(T instance);
        #endregion
    }
}
