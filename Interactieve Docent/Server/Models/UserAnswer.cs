using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    [DataContract]
    public class UserAnswer
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
    }
}