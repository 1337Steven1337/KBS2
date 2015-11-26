using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class PredefinedAnswer
    {
        public int Id { get; private set; }
        public int Question_Id { get; private set; }

        public string Text { get; set; }

        public Question Question;
    }
}
