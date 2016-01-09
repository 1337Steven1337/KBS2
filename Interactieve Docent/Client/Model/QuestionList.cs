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

        public List<Question> MCQuestions = new List<Question>();
        public List<OpenQuestion> OpenQuestions = new List<OpenQuestion>();

        public QuestionList(Dictionary<string, object> data)
        {
            this.Name = Convert.ToString(data["Name"]);
        }

        public QuestionList()
        {

        }

        //Needed for asking the user for confirmation while deleting the list
        public override string ToString()
        {
            return Name;
        }
    }
}
