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
            questionController.loadAddQuestion += QuestionController_LoadAddQuestion;
            questionController.quitAddQuestion += QuestionController_QuitAddQuestion;

            ViewQuestionList viewQuestionList = new ViewQuestionList();
            this.questionListController = new QuestionListController(viewQuestionList, questionController);

            threeColTable.Controls.Add(questionListController.loadQuestionListView(), 0, 0);
            threeColTable.Controls.Add(questionController.loadQuestionView(), 1, 0);
        }

        private void QuestionController_LoadAddQuestion(object sender, System.EventArgs e)
        {                             
            if (threeColTable.ColumnStyles[2].Width <= 0)
            {
                for (int i = 0; i < threeColTable.ColumnCount; i++)
                {
                    threeColTable.ColumnStyles[i].Width = 33.33F;
                }
                threeColTable.Controls.Add(questionController.loadAddQuestionView(), 2, 0);
            }
        }

        private void QuestionController_QuitAddQuestion(object sender, System.EventArgs e)
        {
            threeColTable.Controls.RemoveAt(2);
            float width = 0;
            for (int i = 0; i < threeColTable.ColumnCount; i++)
            {            
                if (i < 2)
                {
                    width = 50F;
                }
                else
                {
                    width = 0;
                }            
                threeColTable.ColumnStyles[i].Width = width;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            panel.Controls.Clear();
            ViewDiagram view = new ViewDiagram();
            DiagramController controller = new DiagramController(view, questionController);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            panel.Controls.Clear();
            ViewQuestion view = new ViewQuestion();
            //QuestionController controller = new QuestionController(view, panel);
        }


    }
}
