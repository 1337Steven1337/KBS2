using Client.View.Question;
using System.Windows.Forms;
using Client.Factory;

namespace Client.Controller
{
    public class QuestionController
    {
        private IQuestionView view;
        private Panel panel;
        private QuestionFactory factory = new QuestionFactory();

        public QuestionController(IQuestionView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);

            loadQuestion();
            this.panel.Controls.Add(view.getPanel());
        }

        private void loadQuestion()
        {
            factory.findAll(this.panel, this.view.fillList);
        }
    }
}
