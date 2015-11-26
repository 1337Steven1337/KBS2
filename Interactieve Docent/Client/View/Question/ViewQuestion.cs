using System.Windows.Forms;
using Client.Controller;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView
    {
        private QuestionController controller;

        public ViewQuestion()
        {
            InitializeComponent();
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }

        public Panel getPanel()
        {
            return panel;
        }
    }
}
