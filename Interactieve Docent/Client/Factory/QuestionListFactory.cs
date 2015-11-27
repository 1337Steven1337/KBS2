using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory
    {
        private const string resource = "QuestionLists";

        public void save(QuestionList list, Action<QuestionList> callback)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Name", list.Name);
            values.Add("Ended", list.Ended);

            this.save<QuestionList>(values, resource, callback);
        }

        public void findById(int id, Action<QuestionList> callback)
        {
            this.findById<QuestionList>(id, resource, callback);
        }

        public void findAll(Control control, Action<List<QuestionList>> callback)
        {
            this.findAll<QuestionList>(resource, control, callback);
        }

        public void findAllAsync(Action<List<QuestionList>> callback)
        {
            this.findAllAsync<QuestionList>(resource, callback);
        }
    }
}
