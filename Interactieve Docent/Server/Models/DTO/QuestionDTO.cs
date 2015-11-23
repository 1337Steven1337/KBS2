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
        public int Time { get; set; }
        public int Points { get; set; }
        public int List_Id { get; set; }
        public List<PredefinedAnswerDTO> PredefinedAnswers { get; set; }
        public List<UserAnswerDTO> UserAnswers { get; set; }
        
        public QuestionDTO()
        {

        }
        public QuestionDTO(Question q)
        {
            this.Id = q.Id;
            this.Text = q.Text;
            this.Time = q.Time;
            this.Points = q.Points;
            this.List_Id = q.List_Id;
        }
    }
}