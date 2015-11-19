using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class PredefinedAnswerDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuestionId { get; set; }

        public PredefinedAnswerDTO(PredefinedAnswer PreAnswer)
        {
            this.Id = PreAnswer.Id;
            this.Text = PreAnswer.Text;
        }

        public PredefinedAnswerDTO()
        {
        }
    }
}