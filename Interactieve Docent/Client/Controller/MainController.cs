using System;
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
            if(controller is ListQuestionController)
            {
                ViewQuestion view = (ViewQuestion)controller.GetView();
                view.AddQuestionClicked += View_AddQuestionClicked;
                view.AddToParent((IView)this.mainView);
            }
            else if(controller is ListQuestionListController)
            {
                ViewQuestionList view = (ViewQuestionList)controller.GetView();
                view.AddToParent((IView)this.mainView);
            }
        }

        private void View_AddQuestionClicked()
        {
            ViewAddQuestion addQuestionView = new ViewAddQuestion();
            AddQuestionController controller = new AddQuestionController();
            controller.SetView(addQuestionView);

            addQuestionView.AddToParent((IView)this.mainView);
        }  
    }
}
