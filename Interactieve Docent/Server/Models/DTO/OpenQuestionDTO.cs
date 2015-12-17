using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class OpenQuestionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Pincode_Id { get; set; }

        public OpenQuestionDTO(OpenQuestion question)
        {
            this.Id = question.Id;
            this.Text = question.Text;
            this.Pincode_Id = question.Pincode_Id;
        }
    }
}