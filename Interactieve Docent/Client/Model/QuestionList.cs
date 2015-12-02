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
        public int Position = -1;

        public string Name { get; set; }
        public bool Ended { get; set; }

        public List<Question> Questions = new List<Question>();

        //Needed for using foreach on object
        public object Current
        {
            get { return Questions[Position]; }
        }

        //Needed for asking the user for confirmation while deleting the list
        public override string ToString()
        {
            return Name;
        }

        //Needed for using foreach on object
        public bool MoveNext()
        {
            Position++;
            return (Position < Questions.Count);
        }

        //Needed for using foreach on object
        public void Reset()
        { Position = 0; }

        //Needed for using foreach on object

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
