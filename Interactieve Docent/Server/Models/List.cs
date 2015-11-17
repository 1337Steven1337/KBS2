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
    public class List
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }

        public List()
        {
            this.Questions = new List<Question>();
        }
    }
}