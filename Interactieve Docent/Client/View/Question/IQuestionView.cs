using Client.Controller;
using System.Windows.Forms;

namespace Client.View.Question
{
    public interface IQuestionView
    {
        void setController(QuestionController controller);
        Panel getPanel();
    }
}
