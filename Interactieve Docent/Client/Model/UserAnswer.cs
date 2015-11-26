using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class UserAnswer
    {
        public int Id { get; private set; }
        public int Question_Id { get; private set; }
        public int PredefintedAnswer_Id { get; private set; }

        public Question Question;

        public PredefinedAnswer PredefinedAnswer;
    }
}
