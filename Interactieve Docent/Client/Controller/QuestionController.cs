using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View.Question;

namespace Client.Controller
{
    public class QuestionController
    {
        IQuestionView view;

        public QuestionController(IQuestionView view)
        {
            this.view = view;
            this.view.setController(this);
        }


    }
}
