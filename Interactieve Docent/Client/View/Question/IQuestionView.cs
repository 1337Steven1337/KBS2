using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;

namespace Client.View.Question
{
    public interface IQuestionView
    {
        void setController(QuestionController controller);
    }
}
