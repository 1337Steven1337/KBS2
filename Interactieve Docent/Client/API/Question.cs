using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    public class Question
    {
        public int id { get; set; }
        public string Text { get; set; }

        public static List<Question> getAll()
        {
            Api api = new Api();

            var request = new RestRequest();
            request.Resource = "Questions";

            return api.Execute<List<Question>>(request);
        }
    }
}
