﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.View.Main;
using Client.View.Question;
using Client.View.QuestionList;

namespace Client.Controller
{
    public class MainController
    {
        private IViewMain mainView;

        public MainController(IViewMain mainView)
        {
            this.mainView = mainView;
            this.mainView.setController(this);
        }

        public void AddController(IController controller)
        {
            if(controller is QuestionController)
            {
                //controller.getView().
            }
        }

        public void loadPanel()
        {

        }

    }
}
