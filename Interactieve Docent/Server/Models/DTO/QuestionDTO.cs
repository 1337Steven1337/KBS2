﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ListId { get; set; }
        public List<PredefinedAnswerDTO> PredefinedAnswers { get; set; }
        
    }
}