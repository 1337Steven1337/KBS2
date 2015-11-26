using Client.View.Question;
using System.Windows.Forms;

namespace Client.Controller
{
    public class QuestionController
    {
        IQuestionView view;
        Panel panel;

        public QuestionController(IQuestionView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);
        }
    }
}
