using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    public class Pincode
    {
        [Key]
        [DataMember]
        public string Id { get; set; }
    }
}