using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class UserAnswer
    {
        public int Id { get; private set; }
        public int Question_Id { get; private set; }
        public int PredefinedAnswer_Id { get; private set; }
    }
}
