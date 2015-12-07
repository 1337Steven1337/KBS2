using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API.Models
{
    [System.Obsolete("Use the new API")]
    public class List : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Ended { get; set; }

        public List<Model.Question> Questions { get; set; }

        public List()
        {

        }

        public List(bool shouldFetch = true)
        {
            this._fetched = !shouldFetch;
            //this.Questions = new List<int>();
        }

        public void Save()
        {
            RestRequest request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Name", this.Name);
            request.Resource = "Lists";

            List q = Api.Execute<List>(request);
            this.copyValues<List>(this, q);
            this._fetched = true;
        }

        public void update()
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Id", this.Id);
            request.AddParameter("Name", this.Name);
            request.Resource = "Lists/" + this.Id;

            List q = Api.Execute<List>(request);
        }

        public void Delete()
        {
            RestRequest request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Id", this.Id);
            request.Resource = "Lists";

            List q = Api.Execute<List>(request);
            this.copyValues<List>(this, q);
            this._fetched = true;
        }

        public static List getById(int id)
        {
            return List.getById<List>(id, "Lists");
        }

        public static List<List> getAll()
        {
            return List.getAll<List>("Lists");
        }

        protected override void fetch()
        {
            List q = List.getById(this.Id);
            this.copyValues<List>(this, q);
            this._fetched = true;
        }
    }
}
