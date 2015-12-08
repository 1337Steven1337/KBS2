﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View.Main;
using Client.View.Question;
using Client.View.QuestionList;
using Client.Controller.Question;
using Client.View;
using Client.Controller.QuestionList;
using Client.Controller;
using Client.Model;

namespace Client.Controller
{
    public class MainController
    {
        private IViewMain MainView;
        private ListQuestionController ListQuestionController;

        public MainController(IViewMain mainView)
        {
            this.MainView = mainView;
            this.MainView.setController(this);
        }

        public void AddController(IController controller)
        {
            if(controller is ListQuestionController)
            {
                ViewQuestion view = (ViewQuestion)controller.GetView();
                view.AddQuestionClicked += View_AddQuestionClicked;
                view.AddToParent((IView)this.MainView);

                this.ListQuestionController = (ListQuestionController)controller;
            }
            else if(controller is ListQuestionListController)
            {
                ViewQuestionList view = (ViewQuestionList)controller.GetView();
                view.AddToParent((IView)this.MainView);
            }
        }

        private void View_AddQuestionClicked(Model.QuestionList list)
        {
            ViewAddQuestion addQuestionView = new ViewAddQuestion();
            AddQuestionController controller = new AddQuestionController();
            controller.SetView(addQuestionView);
            controller.SetQuestionList(list);

            controller.QuestionAdded += this.ListQuestionController.QuestionAdded;

            addQuestionView.AddToParent((IView)this.MainView);
        }  
    }
}
