using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestOpenQuestionDbSet : TestDbSet<OpenQuestion>
    {
        public override OpenQuestion Find(params object[] keyValues)
        {
            return this.SingleOrDefault(question => question.Id == (int)keyValues.Single());
        }
    }
}
