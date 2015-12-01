using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RestSharp;

namespace Client.API.Models
{
    public class UserAnswer : Entity
    {
        public int Id { get; private set; }
        public PredefinedAnswer PredefinedAnswer { get; set; }
        public int PredefinedAnswer_Id { get; set; }
        public int Question_ID { get; set; }

        public static UserAnswer getById(int id)
        {
            return UserAnswer.getById<UserAnswer>(id, "UserAnswers");
        }

        public static List<UserAnswer> getAll()
        {
            return UserAnswer.getAll<UserAnswer>("UserAnswers");
        }

        protected override void fetch()
        {
            UserAnswer ua = UserAnswer.getById(this.Id);
            this.copyValues<UserAnswer>(this, ua);
            this._fetched = true;
        }

        public void saveAnswer()
        {
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("Question_Id", this.Question_ID);
            request.AddParameter("PredefinedAnswer_Id", PredefinedAnswer_Id);
            request.Resource = "UserAnswers";
            List q = Api.Execute<List>(request);
        }
    }
}
