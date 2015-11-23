using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    public abstract class Entity
    {
        public bool _fetched = false;
        protected abstract void fetch();
        
        /// <summary>
        /// Merges two objects into one
        /// </summary>
        /// <typeparam name="T">Defines the type of the objects</typeparam>
        /// <param name="target">Target object to copy the properties to</param>
        /// <param name="source">Source object to copy the properties from</param>
        protected void copyValues<T>(T target, T source)
        {
            Type t = typeof(T);

            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(source, null);
                if (value != null)
                    prop.SetValue(target, value, null);
            }
        }

        /// <summary>
        /// Finds an object by ID
        /// </summary>
        /// <typeparam name="T">Defines the type of the object</typeparam>
        /// <param name="id">The id of the object to fetch</param>
        /// <param name="resource">The resource name of the object</param>
        /// <returns></returns>
        public static T getById<T>(int id, string resource) where T : Entity, new()
        {
            var request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            T entity = Api.Execute<T>(request);
            entity._fetched = true;

            return entity;
        }

        /// <summary>
        /// Finds all objects associated with a resource
        /// </summary>
        /// <typeparam name="T">Defines the type of the object</typeparam>
        /// <param name="resource">The resource name of the object</param>
        /// <returns></returns>
        public static List<T> getAll<T>(string resource)
        {
            var request = new RestRequest();
            request.Resource = resource;

            return Api.Execute<List<T>>(request);
        }
    }
}
