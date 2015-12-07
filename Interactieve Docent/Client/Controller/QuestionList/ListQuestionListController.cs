using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View;
using Client.View.QuestionList;

namespace Client.Controller.QuestionList
{
    public class ListQuestionListController : IController
    {

        private IQuestionListView view;
        //private

        public ListQuestionListController(IView view) 
        {
            this.SetView(view);
        }
            
        public IView GetView()
        {
            return this.view;
        }

        public void SetView(IView view)
        {
            this.view = (IQuestionListView)view;
        }
    }
}
