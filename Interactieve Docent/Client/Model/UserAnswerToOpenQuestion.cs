using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class UserAnswerToOpenQuestion : AbstractModel
    {
        public override int Id { get; set; }
        public int Question_Id { get; set; }
        public string Answer { get; set; }
        public string Student { get; set; }

        public UserAnswerToOpenQuestion() { }

        public UserAnswerToOpenQuestion(Dictionary<string, object> data)
        {
            this.Question_Id = Convert.ToInt32(data["Question_Id"]);
            this.Answer = Convert.ToString(data["Answer"]);
            this.Student = Convert.ToString(data["Student"]);
        }
    }

}
