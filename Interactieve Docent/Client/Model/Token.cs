using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class Token : AbstractModel
    {
        public override int Id { get; set; }
        public string Value { get; set; }
    }
}
