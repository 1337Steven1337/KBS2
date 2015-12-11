using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    public class Token
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Value { get; set; }
    }
}