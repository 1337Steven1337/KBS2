using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Account : AbstractModel
    {
        public override int Id { get; set; }
        public string Student { get; set; } 
        public string Password { get; set; }    
        public string Token { get; set; }
    }
}
