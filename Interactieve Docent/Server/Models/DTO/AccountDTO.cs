using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Student { get; set; }
        public string Token { get; set; }

        public AccountDTO() 
        {
               
        }
        public AccountDTO(Account a)
        {
            this.Id = a.Id;
            this.Student = a.Student;
            this.Token = a.Token;
        }
    }
}