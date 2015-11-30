using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Event
{
    public class QuestionControllerSelectedIndexChanged
    {
        public Question question { get; private set; }

        public QuestionControllerSelectedIndexChanged(Question q)
        {
            this.question = q;
        }
    }
}
