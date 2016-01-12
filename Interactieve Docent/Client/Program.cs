using System;
using System.Windows.Forms;
using Client.Controller;
using Client.View.Main;
using Client.View.Question;
using Client.Controller.Question;
using Client.View.QuestionList;
using Client.Controller.QuestionList;
using Client.Controller.Main;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool student = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form AppView = null;

            if (student)
            {
                StartView view = new StartView();
                ShowStartController controller = new ShowStartController(view);

                AppView = view;
            }
            else
            {
                MainView view = new MainView();
                MainController maincontroller = new MainController(view);

                ListQuestionView viewQuestion = new ListQuestionView();
                ListQuestionController questionController = new ListQuestionController(viewQuestion);
                maincontroller.AddController(questionController);

                ListQuestionListView viewQuestionList = new ListQuestionListView();
                ListQuestionListController listQuestionListController = new ListQuestionListController(viewQuestionList);
                maincontroller.AddController(listQuestionListController);

                listQuestionListController.SelectedListChanged += questionController.LoadList;
                listQuestionListController.Load();

                AppView = view;
            }

            Application.Run(AppView);
        }
    }
}
