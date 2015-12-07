using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View;
using Client.View.Question;

namespace Client.Controller.Question
{
    public class ListQuestionController : IController
    {
        private IQuestionView view;

        public ListQuestionController(IView view)
        {
            this.SetView(view);
        }

        public IView GetView()
        {
            return this.view;
        }

        public void SetView(IView view)
        {
            this.view = (IQuestionView)view;
        }
    }
}
