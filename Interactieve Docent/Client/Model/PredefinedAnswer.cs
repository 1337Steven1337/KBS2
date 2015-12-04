using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class PredefinedAnswer : AbstractModel
    {
        public override int Id { get; set; }
        public int Question_Id { get; set; }
        public bool RightAnswer { get; set; }
        public string Text { get; set; }

        public Question Question;
    }
}
