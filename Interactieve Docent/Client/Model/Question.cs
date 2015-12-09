using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Question : AbstractModel
    {
        public override int Id { get; set; }
        public int Points { get; set; }
        public int Time { get; set; }
        public int List_Id { get; set; }
        public int PredefinedAnswerCount { get; set; }

        public string Text { get; set; }

        public QuestionList QuestionList { get; set; }

        public Question() { }
        public Question(Dictionary<string, object> data)
        {
            this.Points = Convert.ToInt32(data["Points"]);
            this.Time = Convert.ToInt32(data["Time"]);
            this.Text = Convert.ToString(data["Text"]);
            this.PredefinedAnswerCount = Convert.ToInt32(data["PredefinedAnswerCount"]);
            this.List_Id = Convert.ToInt32(data["List_Id"]);
        }

        public override string ToString()
        {
            return Text;
        }

        public List<PredefinedAnswer> PredefinedAnswers { get; set; }

        public List<UserAnswer> UserAnswers { get; set; }
    }
}
