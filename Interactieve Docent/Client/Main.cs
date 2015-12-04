using System.Windows.Forms;
using Client.Controller;
using Client.View.Tabs;
using Client.View.QuestionList;
using Client.View.Question;
using Client.View.Diagram;

namespace Client
{
    public partial class Main : Form
    {
        private TabsController controller;
        private QuestionController questionController;
        private QuestionListController questionListController;

        public Main()
        {
            InitializeComponent();

            ViewTabs view = new ViewTabs();
            controller = new TabsController(view);

            ViewQuestion viewQuestion = new ViewQuestion();
            this.questionController = new QuestionController(viewQuestion);
            this.questionController.setTable(tableThreeColls);

            ViewQuestionList viewQuestionList = new ViewQuestionList();
            this.questionListController = new QuestionListController(viewQuestionList, questionController);

            tableThreeColls.Controls.Add(viewQuestionList.getPanel(), 0, 0);
            tableThreeColls.Controls.Add(viewQuestion.getPanel(), 1, 0);
        }       
    }
}
