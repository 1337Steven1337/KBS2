using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    [KnownType(typeof(Server.Models.List))]
    [KnownType(typeof(Server.Models.PredefinedAnswer))]
    public class Question
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public List List { get; set; }
        [DataMember]
        public ICollection<PredefinedAnswer> PredefinedAnswers { get; set; }
        
        public Question()
        {
            this.PredefinedAnswers = new List<PredefinedAnswer>();
        }
    }
}