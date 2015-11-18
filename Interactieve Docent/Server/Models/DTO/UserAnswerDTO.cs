using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }
        public PredefinedAnswerDTO PredefinedAnswer { get; set; }

        public UserAnswerDTO(UserAnswer ua)
        {
            this.Id = ua.Id;
            this.PredefinedAnswer = new PredefinedAnswerDTO(ua.PredefinedAnswer);
        }
    }
}