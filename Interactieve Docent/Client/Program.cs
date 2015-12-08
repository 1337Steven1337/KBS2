using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.View.Main;
using Client.View.Question;
using Client.Controller.Question;
using Client.View.QuestionList;
using Client.Controller.QuestionList;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            ViewMain view = new ViewMain();
            MainController maincontroller = new MainController(view);

            ViewQuestion viewQuestion = new ViewQuestion();
            ListQuestionController questionController = new ListQuestionController(viewQuestion);
            maincontroller.AddController(questionController);

            ViewQuestionList viewQuestionList = new ViewQuestionList();
            ListQuestionListController listQuestionListController = new ListQuestionListController(viewQuestionList);
            maincontroller.AddController(listQuestionListController);

            listQuestionListController.SelectedListChanged += questionController.LoadList;
            listQuestionListController.Load();

            Application.Run(view);
        }
    }
}
