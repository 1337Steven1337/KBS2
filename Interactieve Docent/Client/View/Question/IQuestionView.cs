using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.View.Question
{
    public interface IQuestionView
    {
        void setController(QuestionController controller);
        Panel getPanel();
        void fillList(List<Model.Question> list);
    }
}
