using Client.View.QuestionList;
using System.Windows.Forms;

namespace Client.Controller
{
    public class QuestionListController
    {
        IQuestionListView view;
        Panel panel;

        public QuestionListController(IQuestionListView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);

            Label q = new Label();
            q.Text = "wdwad";
            panel.Controls.Add(q);
        }
    }
}
