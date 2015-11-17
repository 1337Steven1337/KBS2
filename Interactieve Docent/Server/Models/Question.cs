using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [KnownType(typeof(Server.Models.List))]
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public List List { get; set; }
        public ICollection<PredefinedAnswer> PredefinedAnswers { get; set; }
        
        public Question()
        {
            this.PredefinedAnswers = new List<PredefinedAnswer>();
        }
    }
}