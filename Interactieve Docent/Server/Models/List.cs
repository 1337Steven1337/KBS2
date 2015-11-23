using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    [KnownType(typeof(Server.Models.Question))]
    public class List
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage="Enter a name")]
        public string Name { get; set; }

        [DataMember]
        public ICollection<Question> Questions { get; set; }

        public List()
        {
            //this.Questions = new List<Question>();
        }
    }
}