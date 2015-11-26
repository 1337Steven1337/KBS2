using System.Windows.Forms;
using Client.Controller;
using Client.View.Tabs;
using Client.View.QuestionList;
using Client.View.Question;

namespace Client
{
    public partial class Main : Form
    {
        private TabsController controller;

        public Main()
        {
            ViewTabs view = new ViewTabs();
            controller = new TabsController(view);

            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ViewQuestionList view = new ViewQuestionList();
            QuestionListController controller = new QuestionListController(view, panel);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ViewQuestion view = new ViewQuestion();
            QuestionController controller = new QuestionController(view, panel);
        }
    }
}
