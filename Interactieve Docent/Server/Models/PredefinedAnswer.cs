using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.Question))]
    public class PredefinedAnswer
    {
        [Key]
        public int id { get; set; }
        public string text { get; set; }

        public virtual Question question { get; set; }
    }
}