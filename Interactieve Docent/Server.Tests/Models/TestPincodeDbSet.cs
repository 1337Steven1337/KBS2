using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models
{
    class TestPincodeDbSet : TestDbSet<Pincode>
    {
        public override Pincode Find(params object[] keyValues)
        {
            return this.SingleOrDefault(x => x.Id == (string)keyValues.Single());
        }
    }
}
