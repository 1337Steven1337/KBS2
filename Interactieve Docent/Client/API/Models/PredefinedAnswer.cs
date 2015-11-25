using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Client.API.Models
{
    public class PredefinedAnswer : Entity
    {
        private string _text = null;

        public int Id { get; private set; }
        public string Text
        {
            get
            {
                if (!this._fetched && this._text == null)
                {
                    this.fetch();
                }

                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        public void save(int questionId)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Text", this.Text);
            request.AddParameter("Question_Id", questionId);
            request.Resource = "PredefinedAnswers";

            PredefinedAnswer q = Api.Execute<PredefinedAnswer>(request);
        }

        public static PredefinedAnswer getById(int id)
        {
            return PredefinedAnswer.getById<PredefinedAnswer>(id, "PredefinedAnswers");
        }

        public static List<PredefinedAnswer> getAll()
        {
            return PredefinedAnswer.getAll<PredefinedAnswer>("PredefinedAnswers");
        }

        protected override void fetch()
        {
            PredefinedAnswer q = PredefinedAnswer.getById(this.Id);
            this.copyValues<PredefinedAnswer>(this, q);
            this._fetched = true;
        }
    }
}
