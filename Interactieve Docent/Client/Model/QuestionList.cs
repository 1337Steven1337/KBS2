using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class QuestionList: IEnumerator, IEnumerable
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public bool Ended { get; set; }

        public object Current
        {
            get { return Questions[position]; }
        }

        public List<Question> Questions = new List<Question>();
        public int position = -1;

        public override string ToString()
        {
            return Name;
        }

        public bool MoveNext()
        {
            position++;
            return (position < Questions.Count);
        }

        public void Reset()
        { position = 0; }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
