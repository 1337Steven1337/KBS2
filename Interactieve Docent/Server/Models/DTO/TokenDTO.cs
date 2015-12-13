using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class TokenDTO
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public TokenDTO() { }

        public TokenDTO(Token t)
        {
            this.Id = t.Id;
            this.Value = t.Value;
        }
    }
}