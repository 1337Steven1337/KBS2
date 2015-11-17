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

        public List<AnswerDTO> Answers { get; set; }
    }
}