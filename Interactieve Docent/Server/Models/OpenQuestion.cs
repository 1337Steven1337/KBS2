using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Models
{
    [DataContract]
    public class OpenQuestion
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string Pincode_Id { get; set; }

        [DataMember]
        [ForeignKey("Pincode_Id")]
        public virtual Pincode Pincode { get; set; }
    }
}