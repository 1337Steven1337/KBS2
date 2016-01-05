 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Client.Model;
using Client.Service.Thread;

namespace Client.Factory
{
    public class PincodeFactory : AbstractFactory<Model.Pincode>
    {
        protected override string Resource
        {
            get
            {
                return "Pincodes";
            }
        }

        public PincodeFactory() : base(new BaseFactory<Model.Pincode>())
        {

        }
       
        protected override Dictionary<string, object> GetFields(Pincode instance)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Id", instance.Id);

            return dictionary;
        }

        protected override Dictionary<string, object> UpdateFields(Pincode instance)
        {
            throw new NotImplementedException();
        }
    }
}
