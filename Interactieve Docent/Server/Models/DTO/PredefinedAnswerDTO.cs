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
        public int Question_Id { get; set; }

        public PredefinedAnswerDTO() { }
    }
}