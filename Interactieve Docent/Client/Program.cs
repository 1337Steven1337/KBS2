﻿using System;
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


            Client.Student.QuestionForm questionForm = new Client.Student.QuestionForm(160);
            questionForm.Show();

            Application.Run(view);
        }
    }
}
