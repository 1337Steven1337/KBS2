using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    class List
    {
        public int id { get; set; }
        public string Name { get; set; }

        public List<Question> Questions { get; set; }

        public List()
        {
            this.Questions = new List<Question>();
        }

        public static List<List> getAll()
        {
            Api api = new Api();

            var request = new RestRequest();
            request.Resource = "Questions";

            return api.Execute<List<List>>(request);
        }
    }
}
