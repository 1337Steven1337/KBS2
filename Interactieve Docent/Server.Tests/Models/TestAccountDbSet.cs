using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestAccountDbSet : TestDbSet<Account>
    {
        public override Account Find(params object[] keyValues)
        {
            return this.SingleOrDefault(account => account.Id == (int)keyValues.Single());
        }
    }
}
