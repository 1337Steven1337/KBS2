using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class UserAnswerDTO
    {
        private PredefinedAnswerDTO _PA = null;

        public PredefinedAnswerDTO PredefinedAnswer
        {
            get
            {
                return _PA;
            }
        }

        public int Id { get; set; }
        public int Question_Id { get; set; }
        public int PredefinedAnswer_Id { get; set; }
        public string Pincode_Id { get; set; }

        public PredefinedAnswer _PredefinedAnswer {
            set
            {
                this._PA = new PredefinedAnswerDTO(value);
            }
        }

        public UserAnswerDTO() { }

        public UserAnswerDTO(UserAnswer userAnswer)
        {
            this.Id = userAnswer.Id;
            this.Question_Id = userAnswer.Question_Id;
            this.PredefinedAnswer_Id = userAnswer.PredefinedAnswer_Id;
            this.Pincode_Id = userAnswer.Pincode_Id;
        }
    }
}