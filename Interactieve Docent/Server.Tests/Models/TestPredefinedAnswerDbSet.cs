using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestPredefinedAnswerDbSet : TestDbSet<PredefinedAnswer>
    {
        public override PredefinedAnswer Find(params object[] keyValues)
        {
            return this.SingleOrDefault(pa => pa.Id == (int)keyValues.Single());
        }
    }
}
