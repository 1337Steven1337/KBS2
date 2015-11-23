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
        public PredefinedAnswer PredefinedAnswer { get; set; }
        public int PredefinedAnswer_Id { get; set; }
        public UserAnswerDTO() { }
    }
}