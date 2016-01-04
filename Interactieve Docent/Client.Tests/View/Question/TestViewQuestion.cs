using Client.View.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View;
using System.Windows.Forms;
using Client.Controller.Question;
using System.Net;

namespace Client.Tests.View.Question
{
    class TestViewQuestion : IListView<Model.Question>
    {
        private List<Model.Question> Questions = new List<Model.Question>();

        public void AddItem(Model.Question item)
        {
            throw new NotImplementedException();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Model.Question item)
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.Question> list)
        {
            foreach (Model.Question item in list)
            {
                Questions.Add(item);
            }
        }

        public IControlHandler GetHandler()
        {
            return null;
        }

        public Model.Question getSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            //Should be implemented when the controller is needed
        }

        public void ShowDeleteQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowUpdateQuestionListResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Model.Question item)
        {
            throw new NotImplementedException();
        }
    }
}
