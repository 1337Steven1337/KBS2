using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class DocentAccount : AbstractModel
    {
        public override int Id { get; set; }
        public string Docent { get; set; }
        public string Password { get; set; }
    }
}
