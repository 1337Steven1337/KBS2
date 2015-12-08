using Client.Model;
using Client.Service.SignalR;
using Client.Service.Thread;
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
        private IFactory<T> baseFactory { get; set; }
        #endregion

        #region Instances
        protected SignalRClient SignalRClient = null;
        #endregion

        #region Constructors
        public AbstractFactory(IFactory<T> baseFactory)
        {
            this.baseFactory = baseFactory;
            this.baseFactory.SetResource(this.Resource);
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
            this.baseFactory.DeleteAsync(instance, callback);
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
            List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();

            foreach (KeyValuePair<string, object> entry in this.GetFields(instance))
            {
                list.Add(entry);
            }

            this.baseFactory.SaveAsync(list, callback);
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
            this.baseFactory.FindByIdAsync(id, callback);
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
            this.baseFactory.FindAllAsync(callback);
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
        public void Delete(T instance, IControlHandler control, Action<T, HttpStatusCode, IRestResponse> callback)
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
        public void Delete(T instance, IControlHandler control, Action<T, HttpStatusCode> callback)
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
        public void Delete(T instance, IControlHandler control, Action<T> callback)
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
        public void Save(T instance, IControlHandler control, Action<T, HttpStatusCode, IRestResponse> callback)
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
        public void Save(T instance, IControlHandler control, Action<T, HttpStatusCode> callback)
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
        public void Save(T instance, IControlHandler control, Action<T> callback)
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
        public void FindById(int id, IControlHandler control, Action<T, HttpStatusCode, IRestResponse> callback)
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
        public void FindById(int id, IControlHandler control, Action<T, HttpStatusCode> callback)
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
        public void FindById(int id, IControlHandler control, Action<T> callback)
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
        public void FindAll(IControlHandler control, Action<List<T>, HttpStatusCode, IRestResponse> callback)
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
        public void FindAll(IControlHandler control, Action<List<T>, HttpStatusCode> callback)
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
        public void FindAll(IControlHandler control, Action<List<T>> callback)
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

        public void SetBaseFactory(IFactory<T> factory)
        {
            this.baseFactory = factory;
        }
        #endregion
    }
}
