using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Factory
{
    public class AccountFactory : AbstractFactory<Account>
    {
        protected override string Resource
        {
            get
            {
                return "Accounts";
            }
        }

        public AccountFactory() : base(new BaseFactory<Account>())
        {

        }

        protected override Dictionary<string, object> GetFields(Account instance)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Number", instance.Number);
            data.Add("Password", instance.Password);

            return data;
        }
    }
}
