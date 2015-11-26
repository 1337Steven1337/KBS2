using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class QuestionList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Ended { get; set; }

        public List<Question> Questions = new List<Question>();
    }
}
