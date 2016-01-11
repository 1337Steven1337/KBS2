using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class UserAnswer : AbstractModel
    {
        public override int Id { get; set; }
        public int Question_Id { get; set; }
        public int PredefinedAnswer_Id { get; set; }
        public string Pincode_Id { get; set; }
    }
}
