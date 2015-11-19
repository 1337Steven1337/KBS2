using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public List<PredefinedAnswerDTO> PredefinedAnswers { get; set; }

        public List<UserAnswerDTO> UserAnswers { get; set; }

        public QuestionDTO(Question question)
        {
            this.Id = question.Id;
            this.Text = question.Text;

            //DIT LATER NOG AANPASSEN
            foreach(PredefinedAnswer preAnswer in question.PredefinedAnswers)
            {
                this.PredefinedAnswers.Add(null);
            }
            this.PredefinedAnswers = question.PredefinedAnswers.;
            this.UserAnswers = question.
        }
    }
}