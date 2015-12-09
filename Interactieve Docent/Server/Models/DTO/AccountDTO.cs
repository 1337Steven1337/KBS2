using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public AccountDTO() 
        {

        }
        public AccountDTO(Account a)
        {
            this.Id = a.Id;
            this.Number = a.Number;
        }
    }
}