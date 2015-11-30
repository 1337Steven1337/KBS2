using System.Windows.Forms;
using Client.Controller;
using Client.View.Tabs;
using Client.View.QuestionList;
using Client.View.Question;
using Client.View.Diagram;
using Client.View.Question;

namespace Client
{
    public partial class Main : Form
    {
        private TabsController controller;

        public Main()
        {
            InitializeComponent();

            ViewTabs view = new ViewTabs();
            controller = new TabsController(view);

            ViewQuestion questionView = new ViewQuestion();
            QuestionController controllerQuestion = new QuestionController(questionView, mainTable, threeColTable);

            ViewQuestionList listView = new ViewQuestionList();
            QuestionListController controllerList = new QuestionListController(listView, mainTable, threeColTable, controllerQuestion);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            panel.Controls.Clear();
            ViewDiagram view = new ViewDiagram();
            DiagramController controller = new DiagramController(view, panel);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            panel.Controls.Clear();
            ViewQuestion view = new ViewQuestion();
            //QuestionController controller = new QuestionController(view, panel);
        }
    }
}
