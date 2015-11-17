using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
{
    public class Question : Entity
    {
        private string _text = null;

        public int Id { get; private set; }

        public string Text {
            get
            {
                if(!this._fetched && this._text == null)
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

        public static Question getById(int id)
        {
            return Question.getById<Question>(id, "Questions");
        }

        public static List<Question> getAll()
        {
            return Question.getAll<Question>("Questions");
        }

        protected override void fetch()
        {
            Question q = Question.getById(this.Id);
            this.copyValues<Question>(this, q);
            this._fetched = true;
        }
    }
}
