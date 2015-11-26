using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace ClientTestsDiagram
{
    class TestQuestionDbSet : TestDbSet<Client.API.Models.Question>
    {
        public override Client.API.Models.Question Find(params object[] keyValues)
        {
            return this.SingleOrDefault(question => question.Id == (int)keyValues.Single());
        }
    }
}
