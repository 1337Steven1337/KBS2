using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestUserAnswerToOpenQuestionDbSet : TestDbSet<UserAnswerToOpenQuestion>
    {
        public override UserAnswerToOpenQuestion Find(params object[] keyValues)
        {
            return this.SingleOrDefault(ua => ua.Id == (int)keyValues.Single());
        }
    }
}
