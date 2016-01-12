using System;
using System.Collections.Generic;
using Client.Model;

namespace Client.Factory
{
    public class AccountFactory : AbstractFactory<Account>
    {
        public AccountFactory() : base(new BaseFactory<Account>(false)) { }

        protected override string Resource
        {
            get
            {
                return "Accounts";
            }
        }

        protected override Dictionary<string, object> GetFields(Account instance)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Student", instance.Student);
            data.Add("Password", instance.Password);
            data.Add("Pincode_Id", instance.Pincode_Id);
            return data;
        }

        protected override Dictionary<string, object> UpdateFields(Account instance)
        {
            throw new NotImplementedException();
        }
    }
}
