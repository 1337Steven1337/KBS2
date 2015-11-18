using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API
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
