using Client.Factory;
using Client.View.QuestionList;
using System.Windows.Forms;

namespace Client.Controller
{
    public class QuestionListController
    {
        private IQuestionListView view;
        private Panel panel;
        private QuestionListFactory factory = new QuestionListFactory();

        public QuestionListController(IQuestionListView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);
                       
            panel.Controls.Add(view.getPanel());

            loadList();
        }

        private void loadList()
        {
            factory.findAll(panel, this.view.fillList);
        }
    }
}
