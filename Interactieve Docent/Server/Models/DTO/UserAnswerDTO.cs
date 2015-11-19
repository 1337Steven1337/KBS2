using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public PredefinedAnswer PredefinedAnswer { get; set; }

        public UserAnswerDTO() { }
    }
}