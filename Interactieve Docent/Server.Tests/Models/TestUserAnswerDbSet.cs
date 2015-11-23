using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestUserAnswerDbSet : TestDbSet<UserAnswer>
    {
        public override UserAnswer Find(params object[] keyValues)
        {
            return this.SingleOrDefault(ua => ua.Id == (int)keyValues.Single());
        }
    }
}
