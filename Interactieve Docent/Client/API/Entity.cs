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

        protected void copyValues<T>(T target, T source)
        {
            //if (target != null && source != null)
            //{ 
                Type t = typeof(T);

                var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

                foreach (var prop in properties)
                {
                    var value = prop.GetValue(source, null);
                    if (value != null)
                        prop.SetValue(target, value, null);
                }
            //}
        }

        public static T getById<T>(int id, string resource) where T : Entity, new()
        {
            var request = new RestRequest();
            request.Resource = resource;
            request.AddParameter("Id", id);

            T entity = Api.Execute<T>(request);
            entity._fetched = true;

            return entity;
        }

        public static List<T> getAll<T>(string resource)
        {
            var request = new RestRequest();
            request.Resource = resource;

            return Api.Execute<List<T>>(request);
        }
    }
}
