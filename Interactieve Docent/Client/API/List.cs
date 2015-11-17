using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    public class List
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public List<Question> Questions { get; set; }

        public List()
        {
            //this.Questions = new List<int>();
        }

        public static List<List> getAll()
        {
            var request = new RestRequest();
            request.Resource = "Lists";

            return Api.Execute<List<List>>(request);
        }
    }
}
