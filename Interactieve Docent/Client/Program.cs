using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.View.Main;
using Client.View.Docent;
using Client.View.Question;
using Client.Controller.Question;
using Client.View.QuestionList;
using Client.Controller.QuestionList;
using Client.Controller.Account;
using Client.View.Account;
using Client.View.Authorisation;
using Client.View.Diagram;
using Client.Controller.Main;
using Client.View.OpenQuestion;
using Client.Controller.OpenQuestion;

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


            //MainView view = new MainView();
            //MainController maincontroller = new MainController(view);

            //ListQuestionView viewQuestion = new ListQuestionView();
            //ListQuestionController questionController = new ListQuestionController(viewQuestion);
            //maincontroller.AddController(questionController);

            //ListQuestionListView viewQuestionList = new ListQuestionListView();
            //ListQuestionListController listQuestionListController = new ListQuestionListController(viewQuestionList);
            //maincontroller.AddController(listQuestionListController);

            //listQuestionListController.SelectedListChanged += questionController.LoadList;
            //listQuestionListController.Load();

            //Student.QuestionForm form = new Student.QuestionForm(1);
            //form.Show();

            //AuthorisationView view = new AuthorisationView();
            //AuthorisationController controller = new AuthorisationController(view);

            // AddAccountView view = new AddAccountView();
            // AddAccountController controller = new AddAccountController(view);

            StartView view = new StartView();
            ShowStartController controller = new ShowStartController(view);
            //Application.Run(new ListOpenQuestionView());

            Application.Run(view);
        }
    }
}
