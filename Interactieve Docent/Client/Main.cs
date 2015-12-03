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

            tableThreeColls.Controls.Add(viewQuestionList.getPanel(), 0, 0);
            tableThreeColls.Controls.Add(viewQuestion.getPanel(), 1, 0);
        }

        private void QuestionController_LoadAddQuestion(object sender, System.EventArgs e)
        {
            tableThreeColls.SuspendLayout();
            if (tableThreeColls.ColumnStyles[2].Width <= 0)
            {
                float width = 0;
                for (int i = 0; i < tableThreeColls.ColumnCount; i++)
                {
                    if(i != 2)
                    {
                        width = 25F;
                    }
                    else
                    {
                        width = 50F;
                    }
                    tableThreeColls.ColumnStyles[i].Width = width;
                    
                }
                tableThreeColls.Controls.Add(questionController.getAddQuestionPanel(), 2, 0);
            }
            tableThreeColls.ResumeLayout(true);
            tableThreeColls.PerformLayout();
        }

        private void QuestionController_QuitAddQuestion(object sender, System.EventArgs e)
        {
            tableThreeColls.SuspendLayout();
            tableThreeColls.Controls.RemoveAt(2);
            float width = 0;
            for (int i = 0; i < tableThreeColls.ColumnCount; i++)
            {            
                if (i < 2)
                {
                    width = 50F;
                }
                else
                {
                    width = 0;
                }            
                tableThreeColls.ColumnStyles[i].Width = width;
            }
            tableThreeColls.ResumeLayout(true);
            tableThreeColls.PerformLayout();
        }
    }
}
