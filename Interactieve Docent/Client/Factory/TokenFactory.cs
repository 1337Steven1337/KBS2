using Client.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model;
using System.Net;
using RestSharp;

namespace Client.Factory
{
    class TokenFactory : AbstractFactory<Model.Token>
    {
        protected override string Resource { get; } 

        public TokenFactory() : base(new BaseFactory<Model.Token>())
        {

        }

        protected override Dictionary<string, object> GetFields(Token instance)
        {
            throw new NotImplementedException();
        }

        public void saveAsync(Account account, Action<Token, HttpStatusCode, IRestResponse> callback)
        {
            RestRequest request = new RestRequest();
            request.Resource = Resource;
            request.Method = Method.POST;
            
            request.AddParameter("username", account.Student);
            request.AddParameter("password", account.Password);

            this.GetBaseFactory().ExecuteAsync<Token>(request, response => {
                if (callback != null)
                {
                    callback(response.Data, response.StatusCode, response);
                }
            });
        }

        protected override Dictionary<string, object> UpdateFields(Token instance)
        {
            throw new NotImplementedException();
        }
    }
}
