using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Factory
{
    public class QuestionListFactory : AbstractFactory
    {
        public void getById(int id, Action<QuestionList> callback)
        {
            this.getById<QuestionList>(id, "Questions", callback);
        }
    }
}
