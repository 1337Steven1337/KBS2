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
        private List<PredefinedAnswer> _predefinedAnswers = null;
        private List<UserAnswer> _userAnswers = null;

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

        public List<PredefinedAnswer> PredefinedAnswers {
            get
            {
                if (!this._fetched && this._predefinedAnswers == null)
                {
                    this.fetch();
                }

                return this._predefinedAnswers;
            }
            set
            {
                this._predefinedAnswers = value;
            }
        }

        public List<UserAnswer> UserAnswers
        {
            get
            {
                if (!this._fetched && this._userAnswers == null)
                {
                    this.fetch();
                }

                return this._userAnswers;
            }
            set
            {
                this._userAnswers = value;
            }
        }


        public Question ()
        {
            this._fetched = true;
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
