using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public PredefinedAnswer PredefinedAnswer { get; set; }

        [DataMember]
        public Question Question { get; set; }
    }
}