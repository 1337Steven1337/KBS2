using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    [KnownType(typeof(Server.Models.Question))]
    [DataContract]
    public class UserAnswer
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PredefinedAnswer_Id { get; set; }

        [DataMember]
        [ForeignKey("PredefinedAnswer_Id")]
        public virtual PredefinedAnswer PredefinedAnswer { get; set; }

        [DataMember]
        public int Question_Id { get; set; }

        [DataMember]
        public string Pincode_Id { get; set; }

        [DataMember]
        [ForeignKey("Question_Id")]
        public virtual Question Question { get; set; }

        [DataMember]
        [ForeignKey("Pincode_Id")]
        public virtual Pincode Pincode { get; set; }
    }
}