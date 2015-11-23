using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestListDbSet : TestDbSet<List>
    {
        public override List Find(params object[] keyValues)
        {
            return this.SingleOrDefault(list => list.Id == (int)keyValues.Single());
        }
    }
}
