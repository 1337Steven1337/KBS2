using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class UserAnswerToOpenQuestionDTO
    {
        public int Id { get; set; }
        public int Question_Id { get; set; }
        public string Answer { get; set; }
        public string Student { get; set; }

        public UserAnswerToOpenQuestionDTO() { }

        public UserAnswerToOpenQuestionDTO(UserAnswerToOpenQuestion userAnswer)
        {
            this.Id = userAnswer.Id;
            this.Question_Id = userAnswer.Question_Id;
            this.Answer = userAnswer.Answer;
            this.Student = userAnswer.Student;
        }
    }
}