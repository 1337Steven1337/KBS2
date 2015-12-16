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
using Client.Controller;
using Client.Model;
using Client.Factory;

namespace Client.Controller
{
    public class MainController : AbstractController<Model.Question>
    {
        private IView MainView;
        private ListQuestionController ListQuestionController;
        private AddQuestionView addQuestionView;

        public MainController(IView mainView)
        {
            this.MainView = mainView;
            this.MainView.SetController(this);
        }

        public void AddController(IController controller)
        {
            if(controller is ListQuestionController)
            {
                ListQuestionView view = (ListQuestionView)controller.GetView();
                view.AddQuestionClicked += View_AddQuestionClicked;
                view.AddToParent((IView)this.MainView);

                this.ListQuestionController = (ListQuestionController)controller;
            }
            else if(controller is ListQuestionListController)
            {
                ListQuestionListView view = (ListQuestionListView)controller.GetView();
                view.AddToParent((IView)this.MainView);
            }
        }

        private void View_AddQuestionClicked(Model.QuestionList list, bool edit)
        {
            if (addQuestionView == null)
            {
                addQuestionView = new AddQuestionView(edit);
                AddQuestionController controller = new AddQuestionController();
                controller.SetView(addQuestionView);
                controller.SetQuestionList(list);

                controller.QuestionAdded += this.ListQuestionController.QuestionAdded;
                controller.RemoveAddQuestionPanel += Controller_RemoveAddQuestionPanel;

                addQuestionView.AddToParent((IView)this.MainView);
            }
            else
            {
                Console.WriteLine("Er is al een view open... faggot");
            }
        }

        private void Controller_RemoveAddQuestionPanel()
        {
            MainView view = (MainView)this.MainView;
            view.RemoveAddQuestionPanel();
            addQuestionView = null;
        }

        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetView(IView view)
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.Question> baseFactory)
        {
            throw new NotImplementedException();
        }
    }
}
