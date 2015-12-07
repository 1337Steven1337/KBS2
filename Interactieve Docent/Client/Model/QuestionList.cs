using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class QuestionList : AbstractModel
    {
        public override int Id { get; set; }
        public int Position = -1;

        public string Name { get; set; }
        public bool Ended { get; set; }

        public List<Question> Questions = new List<Question>();

        //Needed for asking the user for confirmation while deleting the list
        public override string ToString()
        {
            return Name;
        }
    }
}
