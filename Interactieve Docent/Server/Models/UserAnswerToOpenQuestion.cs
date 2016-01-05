using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.Question))]
    [DataContract]
    public class UserAnswerToOpenQuestion
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Answer { get; set; }

        [DataMember]
        public int Question_Id { get; set; }

        [DataMember]
        public string Student { get; set; }

        [DataMember]
        [ForeignKey("Question_Id")]
        public virtual Question Question { get; set; }
    }
}