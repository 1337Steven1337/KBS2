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
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    [DataContract]
    public class PredefinedAnswer
    {
        [Key]
        public int id { get; set; }
        public string text { get; set; }

        public Question question { get; set; }
    }
}