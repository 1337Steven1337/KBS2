using System.Windows.Forms;
using Client.Controller;
using Client.View.Tabs;
using Client.View.QuestionList;
using Client.View.Diagram;

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
            ViewDiagram view = new ViewDiagram();
            DiagramController controller = new DiagramController(view, panel);
        }

    }
}
