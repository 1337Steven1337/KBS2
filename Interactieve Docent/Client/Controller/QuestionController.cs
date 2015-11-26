using Client.View.Question;
using System.Windows.Forms;
using Client.Factory;

namespace Client.Controller
{
    public class QuestionController
    {
        IQuestionView view;
        Panel panel;
        private QuestionFactory factory = new QuestionFactory();

        public QuestionController(IQuestionView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);

            panel.Controls.Add(view.getPanel());
        }

        private void loadQuestion()
        {
            //factory.findAll(this.view.fillList);
        }
    }
}
