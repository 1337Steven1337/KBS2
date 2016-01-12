using Client.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
 
namespace Client.Factory
{
    public interface IFactory<T> where T : AbstractModel
    { 
        void SetResource(string resource);
        void DeleteAsync(T instance, Action<T, HttpStatusCode, IRestResponse> callback);
        void SaveAsync(List<KeyValuePair<string, object>> data, Action<T, HttpStatusCode, IRestResponse> callback);
        void FindByIdAsync(object id, Action<T, HttpStatusCode, IRestResponse> callback);
        void FindAllAsync(Action<List<T>, HttpStatusCode, IRestResponse> callback);
        void ExecuteAsync<C>(IRestRequest request, Action<IRestResponse<C>> callback) where C : new();
        void UpdateAsync(List<KeyValuePair<string, object>> data, Action<T, HttpStatusCode, IRestResponse> callback);
    }
}
