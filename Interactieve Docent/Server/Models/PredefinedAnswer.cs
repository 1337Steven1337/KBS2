using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.Question))]
    [KnownType(typeof(Server.Models.List))]
    [DataContract]
    public class PredefinedAnswer
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public Question Question { get; set; }
    }
}