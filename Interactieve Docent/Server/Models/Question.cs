using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    [KnownType(typeof(Server.Models.QuestionList))]
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    [KnownType(typeof(Server.Models.UserAnswer))]
    public class Question
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int Time { get; set; }

        [DataMember]
        public int Points { get; set; }

        [DataMember]
        public int List_Id { get; set; }

        [DataMember]
        [ForeignKey("List_Id")]
        public virtual QuestionList List { get; set; }

        [DataMember]
        public ICollection<PredefinedAnswer> PredefinedAnswers { get; set; }

        [DataMember]
        public ICollection<UserAnswer> UserAnswers { get; set; }
        
        public Question()
        {
            this.PredefinedAnswers = new List<PredefinedAnswer>();
        }
    }
}