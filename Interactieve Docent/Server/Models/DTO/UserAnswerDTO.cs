using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }
        public int Question_Id { get; set; }
        public int PredefinedAnswer_Id { get; set; }
        public PredefinedAnswer PredefinedAnswer { get; set; }
        public UserAnswerDTO() { }

        public UserAnswerDTO(UserAnswer userAnswer)
        {
            this.Id = userAnswer.Id;
            this.Question_Id = userAnswer.Question_Id;
            this.PredefinedAnswer_Id = userAnswer.PredefinedAnswer_Id;
        }
    }
}